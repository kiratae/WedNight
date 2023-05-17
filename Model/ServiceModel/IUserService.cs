﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHunt.WedNight.Model
{
    public interface IUserService
    {
        Task<List<User>> GetListAsync(UserFilter filter, ResultPaging paging);
        User GetData(string userId);
        User SaveData(User user);
        bool DeleteData(string userId);
    }
}
