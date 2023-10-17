using System;
namespace E
{
    interface Picture
    {
        void photo();
        void Video();

    }
    class SadPicture : Picture
    {
        public void photo()
        {
            Console.WriteLine("SAD PHOTO");
        }
        public void Video()
        {
            Console.WriteLine("SAD VIDEO");
        }
    }
    class HappyPicture : Picture
    {
        public void photo()
        {
            Console.WriteLine("HAPPY PHOTO");
        }
        public void Video()
        {
            Console.WriteLine("HAPPY VIDEO");
        }
    }
    class checker(Picture pic)
    {
        pic.photo();
        pic.video();
    }
    class CompInhe
    {
        public static void Main(string[] args)
        {
            //Picture picture = ;
            checker c=new checker(new SadPicture());
        }
    }
}