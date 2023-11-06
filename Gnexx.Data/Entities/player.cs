﻿using Gnexx.Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Gnexx.Data.Entities
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string P_Username { get; set; }

        [Required]
        public string P_Name { get; set; }


        [Required]
        public string P_Lastname { get; set; }

        [Required]
        public string P_Nickname { get; set; }

        [Required]
        public string P_Datebirth { get; set; }

        public string P_Specialization { get; set; }

        [Required]
        public string P_Description { get; set; }

        public string P_Contact { get; set; }

        // Llave foránea para User
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public List<News> News { get; set; }
        public List<Comments> Comments { get; set; }
        public List<Response> Responses { get; set; }


    }
}
