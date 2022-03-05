using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    [Table("Product")]
   public class Produto : Notifies
    {
        [Column("PRD_Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("PRD_Valor")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }


        [Column("PRD_Estado")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }
}
