using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace chapter1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
    private void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text  = "It is so!";
        }

        //protected void ImageTapped(object sender, EventArgs e)
        //    {
        //        Image image = ((Image)sender);
        //        image.Opacity = .5;
        //        image.Opacity = 1;
        //    }
        //Thêm một async / await với độ trễ sẽ làm cho hình ảnh hơi mờ đi trong một phần của giây
        async protected void ImageTapped(object sender, EventArgs e)
        {
            Image image = ((Image)sender);//một cách chuyên nghiệp bằng cách sử dụng thuộc tính 
            //image.Opacity = .5;//Opacity của hình ảnh nhưng thêm async / await để tạo ra một chút
            //await Task.Delay(200);// mờ nhạt mà không ảnh hưởng đến hiệu suất của ứng dụng
            //image.Opacity = 1;
            //Để hoạt ảnh tinh tế hơn, thay vì Opacity, hãy sử dụng phương thức Fadeto
            await image.FadeTo(0.5, 450);
            await Task.Delay(1000);
            await image.FadeTo(1, 450);
        }



    }
}

