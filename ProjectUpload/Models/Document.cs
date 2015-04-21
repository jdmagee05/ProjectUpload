using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectUpload.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string TestName { get; set; }
        public string CourseName { get; set; }
        public string CourseNum { get; set; }
        public string Semester { get; set; }
        public int Year { get; set; }
        public string AnswersIncluded { get; set; }
    }

    public class DocumentDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; } 
    }
}