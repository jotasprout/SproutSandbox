

namespace Models;

public class User
{
    public User(
        string userID,             // userID will be created by index in array of users
        string userName, 
        string password, 
        string firstName, 
        string lastName, 
        string userRole)        // Employee or Manager
                                // is there an advantage to using "this.userID = userID"?        
    {
        this.userID = userID;
        this.userName = userName;
        this.password = password;
        this.firstName = firstName;
        this.lastName = lastName;
        this.userRole = userRole;
    }

public enum userRoles 
{
    Employee,
    Manager
}
    // Why do they have different amounts of references?
    // Why do the number/amounts of references change?
    public string userID {get; set;}
    public string userName {get; set;}
    public string password {get; set;}
    public string firstName {get; set;}
    public string lastName {get; set;}
    public string userRole {get; set;}

}