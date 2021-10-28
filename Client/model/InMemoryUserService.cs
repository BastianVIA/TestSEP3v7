using System;
using System.Collections.Generic;
using System.Linq;
using Client.Data;
using Client.Models;

namespace Client.model{
public class InMemoryUserService : IUserService {
    private List<User> users;

    public InMemoryUserService() {
        users = new[] {
            new User {
                UserName = "User",
                City = "Horsens",
                Domain = "user.dk",
                Password = "123456",
                Role = "Teacher",
                BirthYear = 1986,
                SecurityLevel = 2
            },
            new User {
                UserName = "Admin",
                City = "Kolding",
                Domain = "admin.dk",
                Password = "123456",
                Role = "Admin",
                BirthYear = 1991,
                SecurityLevel = 3
            }
        }.ToList();
    }


    public User ValidateUser(string userName, string password) {
        User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
        if (first == null) {
            throw new Exception("User not found");
        }

        if (!first.Password.Equals(password)) {
            throw new Exception("Incorrect password");
        }

        return first;
    }
}
}