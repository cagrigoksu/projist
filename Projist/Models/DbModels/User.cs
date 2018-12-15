using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Projist.Models.Enums;

namespace Projist.Models.DbModels
{
    public class User
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string UserEmail { get; set; }
        public virtual string UserPassword { get; set; }
        public virtual UserTypeEnum UserType { get; set; }
        public virtual DateTime UserRegisterDate { get; set; }
    }
}