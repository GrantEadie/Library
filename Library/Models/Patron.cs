using System.Collections.Generic;

namespace Library.Models
{
  public class Patron
  {
    public Patron()
    {
      this.Copies = new HashSet<BookCopy>();
    }
  public int PatronId {get; set;}
  public string PatronFirstName {get; set;}
  public string PatronLastName {get;set;}
  
  public virtual ApplicationUser User {get; set;}

  public ICollection<BookCopy> Copies {get;}
  public ICollection<CopyPatron> Patrons {get;}
  public ICollection<BookCopy> Books {get;}
  }
}