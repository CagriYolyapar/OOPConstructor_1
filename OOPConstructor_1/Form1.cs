using OOPConstructor_1.Models;
using OOPConstructor_1.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPConstructor_1
{
    public partial class Form1 : Form
    {



        /*
         
                    Constructor - Yapıcı Metotlar

        Yapıcı metotlar bir sınıf tetiklendiginde ilk calısan metottur... Bir sınıfı tetiklemek icin ya ondan instance alırsınız ya da ondan miras alırsınız...Geriye dönüs tipi acıkca yazılamayan bir metot cesididir...Siz normal şartlarda bu metodu göremezsiniz...Ancak Constructor her daim oradadır. Ya arka planda gizlidir veya belirli şartlarda siz onu acıkca ortaya cıkarırsınız...Siz eger ona bir görev vermek istiyorsanız onu acıkca yazıp ortaya cıkarmanız gerekir...Bir constructor acıkca yazıldıgı andan itibaren tüm hakimiyeti size bırakır (arla planda gizli bir şekilde durmaz)Bu Constructor metotlar geriye deger döndürüp döndürmedikleri acıkca yazılamasa da yine bellir bir metot kategorisine girer...Bu kategori geriye deger döndürmeyen metot kategorisidir... Bu metotların bir özellikleride class ismiyle aynı ismi tasımak zorunda olmalarıdır...Bu metotların görevi isimlerini aldıkları tipten nesne yaratmaktır(instance almaktır)...Eger siz bu metotları acıkca yazarken keyword'lerin yerine void veya herhangi bir tipi acıkca yazmaya calısırsanız syntax hatası  verirler...Constructor metotların class ile aynı isimde olduklarını unutmamalısınız...

         Bu metotlar class'in instance alma işlemi sırasında dilerseniz belli degerleri otomatik olarak atayabilirler ve yarattıkları nesnenin uygun bir degişkene atılmasını new keyword'u ile saglarlar.




        !!!!!!!!İstisnasız her class'ın bir constructor'i vardır...

        //Constructor snippet'i ctor keyword'udur...


        Constructor bir sınıftan instance alma kurallarını belirler...İlgili degerlerin default(varsayılan) olarak gelmesini de saglayabilir dilerseniz parametrik bir şekilde verilmesini de saglayabilir...


        Siz tanımlamadıgınız sürece arka planda gizli olan constructor (varsayılan constructor) parametresiz ve normal şartlarda cagrılabilen, public erişim belirtecine sahip olan bir constructor'dir...Acıkca yazmamızın sebeplerinden bir tanesi class'in olusturdugu nesnesinin bazı degerlerinin daha class tetiklendigi anda ve istenildigi takdirde otomatik olarak verilmesidir veya belli degerlerin tam bu tetikleme anında parametrik bir şekilde verilebilmesini istemektir...Böylece Constructor'i cagırırken argüman verme imkanı da tanırsınız...

        Eger siz Constructor'i elle  yazmıssanız artık  o sınıftan instance alınması sadece sizin belirlediginiz constructorlar ile mümkündür...Cünkü instance almaya artık manuel bir şekilde kural koymussunuzdur...Yani arka planda gizli olan constructor acıga cıkmıstır ve hakimiyeti tamamen size bırakmıstır...Dolayısıyla instance alınırken modifiye etmiş oldugunuz Constructor'a uygun bir şekilde instance almalısınız...Siz nasıl Constructor tanımladıysanı o şekilde instance alınır...


         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         
         */





        public Form1()
        {
            InitializeComponent();
        }


        

       

        private void Form1_Load(object sender, EventArgs e)
        {

        

            Karakter k = new Karakter();
            k.Can = 400;


            Karakter k2 = new Karakter(100);


            Egitmen egt = new Egitmen();
          

            Brans b = new Brans();
          
         
            



        }
    }
}
