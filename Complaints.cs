class Complaint : Product
{
  
  // ito ung class inheritance na galing sa base/parent class
  // na maapply ang relationships ng dalawang class
  // dito rin po nakikita ang ugnayan ng isang parento base class sa derived class na parang iisa lang ang purpose
  // at gustong ipakita sa ibang paraan.
    public Complaint()
    {
        Console.WriteLine("Victoria's Secret Perfume Complaint");
    }
    public new void Name()
    {
        Console.WriteLine("Complaint Product Name: Victoria's Secret Perfume");
    }
    public new void Scent()
    {
        Console.WriteLine("Complaint Product Scent: Bare Vanilla");
    }
    public new void Code()
    {
        Console.WriteLine("Complaint Product Code: 0763381559642");
    }
    public override void Mass()
    {
        Console.WriteLine("Complaint Product Mass: 300 ml");
    }
}
 
 
     Product p1 = new Product();
     p1.Name();
     p1.Scent();
     p1.Code();
     p1.Mass();
 
 
     Product p2 = new Complaint();
     p2.Name();
     p2.Scent();
     p2.Code();
     p2.Mass();

