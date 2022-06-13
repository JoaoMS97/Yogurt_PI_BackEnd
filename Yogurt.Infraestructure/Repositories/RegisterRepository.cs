﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities;
using Yogurt.Domain.Entities.User;
using Yogurt.Infraestructure.Context;
using Yogurt.Infraestructure.Interfaces;

namespace Yogurt.Infraestructure.Repositories
{
    public class RegisterRepository: IRegisterRepository
    {
        private readonly YogurtContext _yogurtContext;

        public YogurtContext YogurtContext => _yogurtContext;

        public RegisterRepository(YogurtContext yogurtContext)
        {
            _yogurtContext = yogurtContext;
        }


        public async Task<Guid> InsertUser(UserEntity entity)
        {
            await _yogurtContext.Usuario.AddAsync(entity);
            await _yogurtContext.SaveChangesAsync();

            return entity.Id;
        }


        public async Task InsertProfile(ProfileUserEntity entity)
        {
            await _yogurtContext.Perfil.AddAsync(entity);
            await _yogurtContext.SaveChangesAsync();
        }

    }
}
