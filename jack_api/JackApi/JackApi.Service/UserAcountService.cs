using System;
using System.Collections;
using System.Collections.Generic;
using JackApi.Domain;

namespace JackApi.Service
{
    public class UserAcountService
    {
        public UserAcountService()
        {
            
        }

        public IEnumerable<UserAcount> GetUsers(int userId)
        {
            if (userId == 0)
            {
                return new List<UserAcount>
                {
                    new UserAcount
                    {
                        UserId = 0,
                        UserName = "fakeUser",
                        Password = "fakePassword"
                    }
                };
            }
            return new List<UserAcount>
            {
                new UserAcount
                {
                    UserId = 0,
                    UserName = "fakeUser",
                    Password = "fakePassword"
                }
            };
        }

        public int AddUser(UserAcount userAcount)
        {
            return 0;
        }
    }
}
