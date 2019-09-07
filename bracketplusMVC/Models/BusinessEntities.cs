using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bracketplusMVC.Models
{
    public class BusinessEntities
    {
        [Key]
        public Int64 BusinessId{get;set;}
        [MaxLength(50)]
        [Column(TypeName = "NVARCHAR")]
       
	    public string Code{get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
        public string Email {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
	    public string Name{get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
	    public string Street {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(150)]
	    public string City {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(150)]
	    public string State {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
	    public string Zip {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(150)]
	    public string Country {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
	    public string Mobile {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
	    public string Phone {get;set;}
        [Column(TypeName = "NVARCHAR")]
       
	    public string ContactPerson {get;set;}
        [Column(TypeName = "NVARCHAR")]
        [MaxLength(50)]
	    public string ReferredBy {get;set;}
        [Column(TypeName = "NVARCHAR")]
       
	    public string Logo {get;set;}
	    public int? Status {get;set;}
	    public double? Balance {get;set;}
         [MaxLength(50)]
         [Column(TypeName = "NVARCHAR")]
	     public string LoginUrl {get;set;}
         [MaxLength(50)]
         [Column(TypeName = "NVARCHAR")]
	     public string SecurityCode {get;set;}
         [MaxLength(50)]
         [Column(TypeName = "NVARCHAR")]
	     public string SMTPServer {get;set;}
	     public int? SMTPPort{get;set;}
         [MaxLength(50)]
         [Column(TypeName = "NVARCHAR")]
	     public string SMTPUsername{get;set;}
         [MaxLength(50)]
         [Column(TypeName = "NVARCHAR")]
        public string SMTPPassword{get;set;}
	   public bool Deleted {get;set;}
	  public DateTime? CreatedOnUtc{get;set;}
         [MaxLength(50)]
        [Column(TypeName = "NVARCHAR")]
	public string UpdatedOnUtc{get;set;}

	public double? CurrentBalance {get;set;} 
    }
}