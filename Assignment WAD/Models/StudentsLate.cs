using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment_WAD.Models
{
    public class StudentsLate
    { 
        [Key]
        public int RollNumber { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Method { get; set; }
        [Required]
        public int Quantily { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PenaltyDate { get; set; }
        private DateTime _returnDate = DateTime.MinValue;
        /*public DateTime ReturnDate
        {
            get
            {
                return (_returnDate == DateTime.MinValue) ? DateTime.Now() : _returnDate;
            }
            set { _returnDate = value; }
        }*/

    }
}