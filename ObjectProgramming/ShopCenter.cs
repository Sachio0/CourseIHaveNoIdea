using System;

namespace ObjectProgramming
{
    public class ShopCenter
    {
        public string Name { get; }
        public ShopCenter(string name)
        {
            Name = name;
        }
        public void AddShop()
        {

        }
        public void AddToilate()
        {

        }
        public void AddBank()
        {

        }

    }
    public class Shop
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
        public string Name { get; }
        public Shop(string name)
        {
            Name = name;
        }
    }
    public class Toilet
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
    }
    public class Bank
    {
        int PositionX { get; set; }
        int PositionY { get; set; }
        public string Name { get; }
        public Bank(string name)
        {
            Name = name;
        }
    }
}
