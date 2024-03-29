﻿using ClassroomHub.Core.Contracts.Repositories;
using ClassroomHub.Core.Entities;
using System.Linq;

namespace ClassroomHub.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {

        }

        public User GetByEmail(string email)
        {
            return this.GetAll().FirstOrDefault(x => x.Email == email);
        }
    }
}
