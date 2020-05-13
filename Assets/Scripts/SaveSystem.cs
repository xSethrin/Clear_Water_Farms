using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/**
* This class creates a save object.  Save objects are used to take primetive data types from gameobjects and put them into a file in binary form
* This class can both create a save and open a save
*/
public class SaveSystem {
    
    /**
    * This method is used to create a save.  It takes game data needed to be saved in the form of a GameData object and converts it to binary.  It then saves that
    * binary data to a file.
    * This method takes a GameData object as a paramater.
    */ 
    public void SaveGame(GameData data){
    
        BinaryFormatter formatter = new BinaryFormatter();//creates a binary formatter object.  This object takes the data and converts it to binary and writes it to a file
        string path = Application.persistentDataPath + "/save.data";//this creates a string of a path to where the game will be saved
        FileStream stream = new FileStream(path, FileMode.Create);//This opens the file stream
        formatter.Serialize(stream, data);//binary data is written to a file
        stream.Close();//clsoe the stream to prevent bugs
        Debug.Log("Game Saved!");
    }

    /**
    * This method is used to load games.  It creates a GameData object from the save file.
    *
    */
    public GameData LoadGame(){
        string path = Application.persistentDataPath + "/save.data";//creates the path to the save data
        if(File.Exists(path)){//makes sure the save file is there
            BinaryFormatter formatter = new BinaryFormatter();//creates a binary formatter
            FileStream stream = new FileStream(path, FileMode.Open);//opens file stream
            GameData data = formatter.Deserialize(stream) as GameData;// creates a GameData object from the binary file
            stream.Close();//closes the stream
            return data;//returns the GameData object
        }
        else{//no save data
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
 
}
