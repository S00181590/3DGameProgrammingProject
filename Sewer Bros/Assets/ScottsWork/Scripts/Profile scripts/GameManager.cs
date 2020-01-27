using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
public delegate void EmptyDelgate();


public class GameManager : MonoBehaviour
{
    public string path;
    static string dataPath;

    //for inventory 
    public ItemList AllItemsInTheGame;
    public static GameManager Instance;

    
    public static UserProfile Profile;

    public static event EmptyDelgate ProfileLoaded;
    //for inventory list
    public static List<Item> MasterCollection;
    public GameObject PopUpBoxPrefab;
    public Canvas RootCanvas;

    //for inventory 
   void Awake()
    {
        MasterCollection = new List<Item>();
        for (int i = 0; i <100; i++ )
        {
            MasterCollection.Add(new Item()
            {
                ID = i,
                Name = "Item" + i,
                Descrption = "Description Text" + i,
                Value = i * 10,
                IconName = "Test Icon"
            });
        }
        path = Application.persistentDataPath;
        dataPath = Application.persistentDataPath + "/";

        CreateRequiredDirectories();

        Profile = new UserProfile()
        {
            Username = "Scott Gallagher"
        };
        GameManager.SaveUserProfile(Profile);
        Profile = GameManager.LoadUserProfiles("Scott Gallagher");
    }
       
    
        public Item FindInventoryItemByID(int itemID)
         {
              return MasterCollection.Find(i => i.ID == itemID);
         }

            public static T LoadAssetsFromResources<T>(string assetPath) where T : UnityEngine.Object //T means its a generic method 
                {
                       return Resources.Load<T>(assetPath);
                }

public void ShowPopUp(string meassage)
{
    GameObject popup = Instantiate(PopUpBoxPrefab, RootCanvas.transform);
    popup.GetComponent<PopUpBox>().IntailzeProjecht(meassage);
}
public static string[] GetAllProfileName()
{
    string[] names = Directory.GetFiles(dataPath + "Saves/", "*.json");

    for (int i = 0; i < names.Length; i++)
    {
        names[i] = Path.GetFileNameWithoutExtension(names[i]);
    }
    return names;
}



public static void CreateUserProfile(string username,Color color,string imageName)
    {
        UserProfile profile = new UserProfile()
        {
            Username = username,
            Color = color,
            ImageName = imageName
        };
        SaveUserProfile(profile);
    }

private void CreateRequiredDirectories()
{
    if (!Directory.Exists(dataPath + "Saves/"))
    {
        Directory.CreateDirectory(dataPath + "Saves/");
    }
}

public static void SaveUserProfile(UserProfile profile)
{
    SaveToJson(dataPath + "Saves/" + profile.Username + ".Json", profile);
}

public static UserProfile LoadUserProfiles(string username)
{
    return LoadFromJson<UserProfile>(dataPath + "Saves/" + username + ".json");
}

public static void LoadandSetUserProfile(string username)
{
    Profile = LoadUserProfiles(username);
    if (ProfileLoaded != null && Profile != null)
        ProfileLoaded();
}


public static void SaveToJson(string path,object objechttoSave)
    {
        string Json = JsonUtility.ToJson(objechttoSave);
        File.WriteAllText(path, Json);
    }
   
    
    public static T LoadFromJson<T> (string path )
    {
        string json = File.ReadAllText(path);
        return JsonUtility.FromJson<T>(json);
    }
   

  
 
    
}

