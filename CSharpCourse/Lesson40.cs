using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCourse
{
    class Lesson40
    {
        //Abstract class vs interface

        /*Giống nhau
         Được sử dụng để đạt được tính trừu tượng trong lập trình.
         Đều chứa các phương thức abstract.
         Đều không thể trực tiếp tạo đối tượng.
         Đều sử dụng để đạt được tính chất đa hình.
         Đều được kế thừa bởi các lớp khác.*/


        



        /*
        Khi nào sử dụng abstract class
        Sử dụng abstract class để tạo lớp cha chung chứa các đặc điểm và hành vi chung nhất của tất cả các lớp con kế thừa nó.
        Sử dụng abstract class khi muốn một chức năng nào đó có ở lớp cha có thể tái sử dụng và cập nhật ở trong lớp con qua override.
        Sử dụng abstract class khi muốn tạo các triển khai mặc định cho tất cả các lớp con.
        Sử dụng abstract class khi không muốn triển khai tất cả các phương thức có trong lớp cha mà chỉ triển khai một vài trong số đó.
        Sử dụng abstract class khi muốn một lớp có thể chứa cả các phương thức abstract và non-abstract.
        Khi nào sử dụng interface
        Sử dụng interface khi muốn đạt được tính kết nối lỏng lẻo(loose coupling) trong lập trình.
        Sử dụng interface khi muốn tất cả các phương thức chưa được triển khai mặc định phải được triển khai đầy đủ trong các lớp con.
        Sử dụng interface để đạt được tính trừu tượng hoàn toàn.
        Sử dụng interface khi muốn phân tách khai báo và triển khai của các phương thức trong quan hệ kế thừa.
        Sử dụng interface để đạt được đa kế thừa.
        Sử dụng interface để tạo ra hành động chung cho các lớp không có liên quan gì tới nhau về mặt kế thừa.*/
    }
}
