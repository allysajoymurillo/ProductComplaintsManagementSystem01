using System;

namespace ProductComplaints
{
     // dito sa class na ito makikita at maaaring madagdagan ang product 
     // na naicomplain sa system at dito rin nai-apply ang inheritance relationship ng class 
     // ang inheritance class na related dito ay ang class complaints na mkikita sa isang file.
     // dito rin nkikita ang product details complaint ng complainant.

class Product
{
    public Product()
    {
        Console.WriteLine("Product Complaints!");
    }
    public void Name()
    {
        Console.WriteLine("Product Name: Victoria's Secret Perfume");
    }
    public void Scent()
    {
        Console.WriteLine("Product Perfume scent: Love Spell");
    }
    public void Code()
    {
        Console.WriteLine("Product Perfume Code: 0667538086212");
    }
        public virtual void Mass()
    {
        Console.WriteLine("Product Mass: 250 ml");
    }
}
      
      
     
