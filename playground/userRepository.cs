using Models;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;

namespace DataAccess;

public class UserRepository
{
    private const string filePath = "./userRegistry.json";
    string fileString = File.ReadAllText(filePath);


    public Dictionary<string, User> GetAllUsers()
    {
        try
        {
            return JsonSerializer.Deserialize<Dictionary<string, User>>(fileString);
        }
        catch(JsonException)
        {
            throw;
        }
    }


    public User GetUserByLastName(string lastName)
    {
        try
        {
            Dictionary<string, User> allUsers = GetAllUsers();
            return allUsers[lastName];
        }
        catch(JsonException)
        {
            throw;
        }
    }    




    public User AddUser(User newUser)
    {
        try
        {
            Dictionary<string, User> allUsers = GetAllUsers();
            allUsers.Add(newUser.firstName, newUser);
            File.WriteAllText(filePath, JsonSerializer.Serialize(allUsers));
            return newUser;
        }
        catch(JsonException)
        {
            throw;
        }
    }
}