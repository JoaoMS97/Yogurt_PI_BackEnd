﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yogurt.Domain.Entities.Base;

namespace Yogurt.Domain.Entities
{
    public class ConnectEntity: EntityBase
    {
        public Guid IdPerfil { get; set; }
        public Guid IdAmizade { get; set; }

        public DateTime DataCriacao { get; set; }

        [ForeignKey("IdPerfil")]
        public virtual ProfileUserEntity Perfil { get; set; }

        [ForeignKey("IdAmizade")]
        public virtual FriendEntity Amizade { get; set; }
    }
}
