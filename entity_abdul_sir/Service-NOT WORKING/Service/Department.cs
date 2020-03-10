using System.ComponentModel.DataAnnotations;


namespace Service
{
    class Department
    {
        [Key] public int D_id { get; set; }
        [Required] public string D_name { get; set; }
        public string location { get; set; }


    }

}
