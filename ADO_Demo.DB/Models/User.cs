using System;
using System.Collections.Generic;
using System.Text;

namespace ADO_Demo.DB.Models
{
    //public class User
    //{
    //    public int id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public IEnumerable<string> Emails { get; set; }
    //}

    public class User//: IEquatable<User>
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<string> Emails { get; set; }

        //bool IEquatable<User>.Equals(User other)
        //{
        //    if (ReferenceEquals(null, other))
        //    {
        //        return false;
        //    }
        //    if (ReferenceEquals(this, other))
        //    {
        //        return true;
        //    }

        //    return id == other.id && FirstName == other.FirstName && LastName == other.LastName && Equals(Emails, other.Emails);

        //}
        //public override bool Equals(object obj)
        //{
        //    if (ReferenceEquals(null, obj))
        //    {
        //        return false;
        //    }
        //    if (ReferenceEquals(this, obj))
        //    {
        //        return true;
        //    }
        //    if (obj.GetType()!= this.GetType())
        //    {
        //        return false;
        //    }

        //    return Equals((User)obj);
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(id, FirstName, LastName, Emails);
        //}

    }

}
