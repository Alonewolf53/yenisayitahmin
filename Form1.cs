/*Program 2 farklı şekilde çalışmaktadır.Program YazılımSayıTahmin Butonu ile sayı üretecek.*/
/*Üretilen sayı label1.text'e eşitlenecek.*/
/*Kullanıcısayıtahmin butonu ile kullanıcı textbox'a veri girişi yaptığı zaman kontrol bununla sağlanacak*/
/*kullanıcının girdiği sayılarla yazılım tuttuğu sayı aynı ise veya sayılardan birinin yeri ve kendisi doğru ise labela yazdırılacak ve + puan alacak*/
/*aksi takdirde - puan alacak ve labellardan sayı doğru olana kadar hiçbirşey yazmayacak*/

/*diğer sistemde ise bizim tuttuğumuz sayıyı yazılım bulmak için tahmin etmeye çalışacak rakamları doğru olan kısmı işaretlediğmiz takdirde yazılım doğru bulduğu sayılara göre üretecek */
/*doğru bulduğunda + puan alacak yanlış bulduğunda ise - puan alacak*/
/*kullanıcıyazılımtahminkontrol ile puan + yada eksi olması sağlanacak*/
/*yazılım tahmin sayı göster ise yazılımın ürettiği sayıyı göstermektedir.İşlemin doğru olup olmadığı bu buton ile kontrol edilebilir*/
/*hata denetimi try catch kullanımı ile sağlanmıştır*/
/*boş değer girilmesi halinde işlem yapılmaya çalışılırsa program uyarı verecek */





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int checkboxsayilari;/*checkbox ile işlem yapabilmek için bu değişkeni kullanırız*/
        int[] checkboxsayidizisi = new int[50];/*checkboxlardan alınan veriler için bunu kullanırız*/
        int syc1 = 0, syc2 = 0, syc3 = 0, syc4 = 0, syc5 = 0, syc6 = 0, syc7 = 0, syc8 = 0,syc9=0,syc10=0,syc11=0,syc12=0,syc13=0,syc14=0,syc15=0,syc16=0,toplamsayac, cikarmasayac;/*sayaç değişkenleri kontrolü sağlamak için bunu kullanırız*/
        int birincisayi, ikinicisayi, ucuncusayi, dorduncusayi, i = 0, toplam,toplam2,ik=0;/*değişkenler tanımlanır*/
        int kullanicitahmin, aktarma;/*kullanıcıddan aldığımız verileri aktarmak için bunu kullanırız*/
        int[] dizi = new int[500];/*dizi değişkeni ile veri alırız.aldığımız verileri dizideki sıra ile işletiriz*/
        int[] kdizi = new int[500];/*kullanıcı işlemlerindeki değişkenleri dizilere sırası ile buna aktarırız*/
        int[] ktsycdz = new int[50];/*aynı şekilde kullanıcıdan aldığımız değişkenleri işletmek için bunu kullanırız*/
        
        
        
        int[] ktsycdzs = new int[50];
        
        int[] kttahmin = new int[100];

        Random r2 = new Random();/*yazılım bizim tahmin ettiğimiz sayıyı bulması için bu random ifadesini kullanırız*/
        int[] kttoplam = new int[100];
        int[] kttsycdzs = new int[80];
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false; 
            label2.Text = "hadi tahmin et bakalım";/* Program ilk başta mesaj atar label2'ye */
            Random r1 = new Random();/*r1 random değeri random sınıfından oluşturulur */
       
            birincisayi = r1.Next(1, 10);/*birinci sayının değeri 1 ile 10 arasında olur 1 dahil 10 dahil olunmaz sebebi ise 4 basamskalı sayı olacağı için ilk basamaktaki sayının 0 olmaması için bu şart konulur  */ 
       
            while (i < 1) /*while döngüsü ile kontrol sağlanır.i değeri 1 den küçük olduğu sürece random sayı üretmeye zorlanır */
            {
            
                ikinicisayi = r1.Next(0, 10); /* ikincisayı değeri 0 dahil 10 dahil değil arasındadır */
                ucuncusayi = r1.Next(0, 10); /* üçüncüsayı değeri 0 dahil 10 dahil değil arasındadır */
                dorduncusayi = r1.Next(0, 10); /* dördüncüsayı değeri 0 dahil 10 dahil değil arasındadır */
                if (birincisayi != ikinicisayi && birincisayi != ucuncusayi && birincisayi != dorduncusayi && ikinicisayi != ucuncusayi && ikinicisayi != dorduncusayi && ucuncusayi != dorduncusayi) /* buradaki kontrol ise sayının basamaklarının birbirinden farklı olması için yapılır.Hedefimiz biribirinden farklı 4 basamaklı sayı girilmesinin sağlamaktır*/
                {
                    toplam = ((birincisayi * 1000) + (ikinicisayi * 100) + (ucuncusayi * 10) + (dorduncusayi * 1)); /*şartımızın sağladığı sayılar 4 basamaklı sayıya çevirilir.Çevirilen sayılar4 basamaklı olmuş olur.toplam değişkenine aktarılır */

                    label1.Text = toplam.ToString(); /*label1.in değerine eşitlenir.toplam değişkenine aktarılan sayılar */
                    i++; /*random sayı oluşturma biter bu sayede */
                    
                    dizi[0] = toplam % 1000;/*oluşturulan toplam sayının mod 1000 alınır ve moddan kalan dizi[0]'a aktarılır */
                    dizi[1] = toplam - dizi[0]; /*daha sonra toplam sayısından mod 1000 den kalan aktarılır */
                    dizi[2] = dizi[1] / 1000;/*daha sonra sayı 1000'e bölünür ve sayının birinci basamağı */
                    dizi[3] = dizi[0] % 100; /*sayının mod 1000 den alındıktan sonra sayının kalan 3 basamağı ise mod 100 alınır"*/
                    dizi[4] = dizi[0] - dizi[3];/* 3 basamaklı sayının kendisinden mod 100e bölümünden kalanı çıkar */
                    dizi[5] = dizi[4] / 100;/*sayıyı 100 e böl sayının 2. basamağını bul */
                    dizi[6] = dizi[3] % 10;/* sayının 3. basamağını bulmak için son 2 basamağı mod 10'a böl*/
                    dizi[7] = dizi[3] - dizi[6];/*sayının son 2 basamağını mod10a bölümünden çıkar*/
                    dizi[8] = dizi[7] / 10;/*sayıyı 10a böl 3. basamağı bul*/
                    dizi[9] = dizi[6];/*sayının 4. basamağı zaten sayının son 2 basamağının mod 10'a bölümüne eşittir*/
                     
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "";
            label2.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        int dizisayac = 0;
        int hata = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            


            
            try/* hata tespiti try'ın içindedir*/
            {


                kullanicitahmin = Convert.ToInt32(textBox1.Text);/* kullanıcının tahmin ettiği sayıyı textbox'ın içinden alıp kullanicitahmin değişkenine aktarıyoruz*/
                aktarma = kullanicitahmin;/*aktarma değişkeni kullanıcıtahmine aktarıyoruz*/
                kdizi[0] = aktarma % 1000; /*aktarma sayısı mod 1000 alınır ve kdizi[0]'a eşitlenir*/
                kdizi[1] = aktarma - kdizi[0];/* kdizi[1] değerine aktarmadan mod 1000den alınan değer çıkartılır*/
                kdizi[2] = kdizi[1] / 1000;/*daha sonra sayı 1000'e bölünür.ve sayının birinci basamağı  bulunur*/
                kdizi[3] = kdizi[0] % 100;/*daha sonra sayının 3 basamağı mod 100 alınırve moddan kalan değer kdizi[3]'e aktarılır*/
                kdizi[4] = kdizi[0] - kdizi[3];/*sonra sayının 3 basamağından mod100den kalan sayı çıkartılır*/
                kdizi[5] = kdizi[4] / 100;/*daha sonra bulunan değer 100'e bölünürve 2. sayı bulunur*/
                kdizi[6] = kdizi[3] % 10;/*sayının 2 basamağı mod 10 alınır.ve kdizi[6]ya aktarılır*/
                kdizi[7] = kdizi[3] - kdizi[6];/*daha sonra sayının 2 basamağı mod10 dan kalanla çıkatılır */
                kdizi[8] = kdizi[7] / 10; /*daha sonra sayının 2 basamağı 10'a bölünür ve 3.sayı bulunur*/
                kdizi[9] = kdizi[6];/*daha sonra 2 basamaklı sayının mod10 bölümümünden sonra kalan sayı sayının 4. basamağı olur*/

            
        
                if (textBox1.TextLength == 4)
                {
                    if ((kdizi[2] / kdizi[5] != 1) || (kdizi[2] / kdizi[8] != 1) || (kdizi[2] / kdizi[9] != 1) || (kdizi[5] / kdizi[8] != 1) || (kdizi[5] / kdizi[9] != 1) || (kdizi[8] / kdizi[9] != 1) || (kdizi[5] / kdizi[2] != 1) || (kdizi[8] / kdizi[2] != 1) || (kdizi[9] / kdizi[2] != 1) || (kdizi[8] / kdizi[5] != 1) || (kdizi[9] / kdizi[5] != 1) || (kdizi[9] / kdizi[8] != 1))/*rakamları aynı 4 basamaklı sayı girlmemesi için bu şart oluşturuldu. bu şarta göre rakamları aynı 4 basamaklı sayı girileceği zaman program aynı sayıları girme diye uyarı verecek.bu şart sağlandığı takdirde kullanıcını girdiği sayı kabul edilecek */
                    {

                        if (birincisayi == kdizi[2])/*eğer kullanıcının girdiği sayılardan birincisi tahmin edilen sayı ile aynı ise bu şart sağlanacak*/
                        {

                            syc1++;/*syc1 artacak ve artan değer + puan olacak*/
                            ktsycdz[0] = syc1;/*daha sonra artan değer ktsycdz[0] değerine eşitlenecek */

                            label20.Text = kdizi[2].ToString();/*kullanıcıya ipucu vermesi açısından birinci sayı labele yazdırılacak*/

                        }


                        if (ikinicisayi == kdizi[5])/*eğer kullanıcının girdiği sayılardan ikincisi tahmin edilen sayı ile aynı ise bu şart sağlanacak*/
                        {

                            syc2++;/*syc2 artacak ve artan değer + puan olacak*/
                            ktsycdz[1] = syc2;/*daha sonra artan değer ktsycdz[1] değerine eşitlenecek */

                            label21.Text = kdizi[5].ToString();/*kullanıcıya ipucu vermesi açısından ikinci sayı labele yazdırılacak*/

                        }

                        if (ucuncusayi == kdizi[8])/*eğer kullanıcının girdiği sayılardan üçüncüsü tahmin edilen sayı ile aynı ise bu şart sağlanacak*/
                        {

                            syc3++;/*syc3 artacak ve artan değer + puan olacak*/

                            ktsycdz[2] = syc3;/*daha sonra artan değer ktsycdz[2] değerine eşitlenecek */
                            label22.Text = kdizi[8].ToString(); /*kullanıcıya ipucu vermesi açısından üçüncü sayı labele yazdırılacak*/


                        }


                        if (dorduncusayi == kdizi[9])/*eğer kullanıcının girdiği sayılardan dördüncüsü tahmin edilen sayı ile aynı ise bu şart sağlanacak*/
                        {

                            syc4++;/*syc4 artacak ve artan değer + puan olacak*/

                            ktsycdz[3] = syc4;/*daha sonra artan değer ktsycdz[3] değerine eşitlenecek */
                            label23.Text = kdizi[9].ToString(); /*kullanıcıya ipucu vermesi açısından dördüncü sayı labele yazdırılacak*/

                        }




                        if (birincisayi != kdizi[2])/*eğer kullanıcının girdiği sayılardan birincisi tahmin edilen sayı ile aynı değilse bu şart sağlanacak*/
                        {
                            

                            syc5++;/*syc5 artacak buda eksi puan olacak*/
                            ktsycdzs[4] = syc5;/*syc5 değeri ktsycdzs[4] değerine eşit olacak*/


                        }


                        if (ikinicisayi != kdizi[5])/*kullanıcının girdiği sayılardan ikincisi tahmin edilen sayı ile aynı değilse bu şart sağlanacak*/
                        {
                            
                            syc6++;/*syc6 aratacak buda eksi puan olacak*/

                            ktsycdzs[5] = syc6;/*syc6 değeri ktsycdzs[5] değerine eşitlenecek*/

                        }

                        if (ucuncusayi != kdizi[8])/*kullanıcının girdiği sayılardan üçüncüsü tahmin edilen sayı ile aynı değilse bu şart sağlanacak*/
                        {
                            

                            syc7++;/*syc7 aratacak buda eksi puan olacak*/

                            ktsycdzs[6] = syc7;/*syc7 değeri ktsycdzs[6] değerine eşitlenecek*/

                        }


                        if (dorduncusayi != kdizi[9])/*kullanıcının girdiği sayılardan dördüncüsü tahmin edilen sayı ile aynı değilse bu şart sağlanacak*/
                        {
                            

                            syc8++;/*syc8 aratacak buda eksi puan olacak*/

                            ktsycdzs[7] = syc8;/*syc8 değeri ktsycdzs[7] değerine eşitlenecek*/

                        }

















                        label5.Text = ((ktsycdz[0] + ktsycdz[1] + ktsycdz[2] + ktsycdz[3]).ToString());/*toplam + puan buraya yazılacak ve burada toplanacak.Toplanan sayılar string tipinden olacak ve label5'e eşit olacak*/

                        label6.Text = (((-1) * (ktsycdzs[4] + ktsycdzs[5] + ktsycdzs[6] + ktsycdzs[7])).ToString());/*toplam - puan buraya yazılacak ve burada toplanacak.Toplanan sayılar string tipinden olacak ve label6'ya eşit olacak*/
                      

                        if (toplam == kullanicitahmin) /*eğer kullanıcının girdiği sayı tahmin edilen sayı ile aynı olursa bu şart sağlanacak*/
                        {
                            MessageBox.Show("tamamdır dostum bu iş");/*ekrana mesaj yazılacak*/
                            dizisayac++;
                            Environment.Exit(0);/*program çıkış yapacak*/
                        }

                        else/*eğer girilen sayı tahmin edilen sayı ile aynı değilse bu şart dönecek*/
                        {


                            DialogResult dr = new DialogResult();/* mesaj kutusu oluşturma komutu*/
                            dr = MessageBox.Show("şansını tekrar dene bence ", "iyi düşün", MessageBoxButtons.OK);/*mesaj oluşturma komutu işleyecek*/

                            if (dr == DialogResult.OK)/* eğer tamam seçilirse bu şart sağlanacak*/
                            {
                                /*
                                ktsycdz[0] = 0;
                                ktsycdz[1] = 0;
                                ktsycdz[2] = 0;
                                ktsycdz[3] = 0;
                                ktsycdzs[4] = 0;
                                ktsycdzs[5] = 0;
                                ktsycdzs[6] = 0;
                                ktsycdzs[7] = 0;
                                 */

                                foreach (Control item in this.Controls)/* Textbox'ı sıfırlamak için bu döngüyü başlatırız*/
                                {

                                    if (item is TextBox)
                                    {

                                        TextBox tbox = (TextBox)item;

                                        tbox.Clear();/* textbox temizlenir*/
                                        /*
                                        label6.Text = "";
                                        label5.Text = "";
                                        */






                                    }



                                }



                            }




                        }






                    }
                    else/* eğer girilen arakmalr aynı ise program uyarı mesajı girecek*/
                    {
                        MessageBox.Show("aynı değerleir girme");
                        foreach (Control item in this.Controls)/* Textbox'ı sıfırlamak için bu döngüyü başlatırız*/
                        {

                            if (item is TextBox)
                            {

                                TextBox tbox = (TextBox)item;

                                tbox.Clear();/* textbox temizlenir*/
                                /*
                                label6.Text = "";
                                label5.Text = "";
                                */






                            }



                        }


                    }
                }
                else
                {
                    MessageBox.Show("4 basamaklıdan büyük yada küçük sayı giremezsin");
                    foreach (Control item in this.Controls)/* Textbox'ı sıfırlamak için bu döngüyü başlatırız*/
                    {

                        if (item is TextBox)
                        {

                            TextBox tbox = (TextBox)item;

                            tbox.Clear();/* textbox temizlenir*/
                            /*
                            label6.Text = "";
                            label5.Text = "";
                            */






                        }



                    }


                }
            }

            catch (Exception g)/*textbox'a boş değer girilmesi halinde program bozuluyor.Bunu önelemek ve kullanıcıyı uyarmak için bu method kullanıldı*/
            {
                MessageBox.Show("boş değer girme");

            }
        
        }
        int il = 0;
        private void button3_Click(object sender, EventArgs e)
        {




















            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)/*bilgisayarın tahmin ettiği sayıyı bulmak için checkboxları kullandık.ve kullandığımız checkboxlar ile şart koyduk.Checkboxların hepsi seçili olana kadar bu şart sağlanacak*/
            {
                ik = 2;
                MessageBox.Show("Hepsi doğru o zaman");
            }

            if (checkBox1.Checked == true)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının birinci rakamıyla aynı ise birinci sayı belirlenir.Birinci sayı hafıza alınmak için labelda gizlenir*/
            {
                label12.Visible = false;

            }

            if (checkBox2.Checked == true)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının ikinci rakamıyla aynı ise ikinci sayı belirlenir.İkinci sayı hafıza alınmak için labelda gizlenir*/
            {
                label13.Visible = false;
            }

            if (checkBox3.Checked == true)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının üçüncü rakamıyla aynı ise üçüncü sayı belirlenir.Üçüncü sayı hafıza alınmak için labelda gizlenir*/
            {
                label14.Visible = false;
            }
            if (checkBox4.Checked == true)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının dördüncü rakamla aynı ise birinci sayı belirlenir.Dördüncü sayı hafıza alınmak için labelda gizlenir*/
            {
                label15.Visible = false;
            }
            if (checkBox1.Checked == false)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının birinci rakamıyla aynı değilse birinci sayı tekrar random olarak çalışır*/
            {
                birincisayi = r2.Next(1, 10);
            }

                while (ik < 1)
                {
                    if (checkBox2.Checked == false)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının ikinci rakamıyla aynı değilse birinci sayı belirlenir.Birinci sayı hafıza alınmak için labelda gizlenir*/
                    {
                        ikinicisayi = r2.Next(0, 10);
                    }
                    if (checkBox3.Checked == false)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının üçüncü rakamla aynı ise üçüncü sayı belirlenir.Üçüncü sayı hafıza alınmak için labelda gizlenir*/
                    {
                        ucuncusayi = r2.Next(0, 10);
                    }
                    if (checkBox4.Checked == false)/*eğer pcnin tahmin ettiği sayı bizim belirlediğimiz sayının dördüncü rakamla aynı ise dördüncü sayı belirlenir.Dördüncü sayı hafıza alınmak için labelda gizlenir*/
                    {
                        dorduncusayi = r2.Next(0, 10);
                    }

                    if (birincisayi != ikinicisayi && birincisayi != ucuncusayi && birincisayi != dorduncusayi && ikinicisayi != ucuncusayi && ikinicisayi != dorduncusayi && ucuncusayi != dorduncusayi)/*checkboxda seçilen sayılar birbiriyle aynı değilse işlem tamamlanır*/
                                                                                                                                                                                                          
                    {
                        toplam2 = ((birincisayi * 1000) + (ikinicisayi * 100) + (ucuncusayi * 10) + (dorduncusayi * 1));/*sayılar 4 basamaklı sayı sistemine çevirilir*/
                        if (toplam2 != toplam)/*pcnin tahmin ettiği sayı ile bizim tahmin ettiğimiz sayının aynı olmaması bu şart ile sağlanır*/
                        {


                            label7.Text = toplam2.ToString();/* sayı labele yazdırılır*/
                            label7.Visible = false;
                            ik++;/* şart sağlandığı için işlem bitirilir*/

                        }

                    }



                }
                DialogResult dialog = MessageBox.Show("doğru ",toplam2.ToString(), MessageBoxButtons.YesNo);/*pcnin tahmin ettiği sayı doğru mu değil mi pc bize sorar evet dersek işlem biter.hayır dersek işleme devam eder*/
                if (dialog == DialogResult.Yes)
                {

                    ik++;/* işlem biter ve pc kazanır*/

                    MessageBox.Show("ben kazandım");
                    Environment.Exit(0);/*programdan çıkış yapılır*/
                }

                else if (dialog == DialogResult.No)/*hayır der ise yazılımın tekrar tahmin etmesi için işlem başlar*/
                {

                    ik--;/*ik azaltılır*/


                }

                checkboxsayilari = Convert.ToInt32(label7.Text);/*pcnin tahmin ettiği sayı integer türüne çevrilip checkboxsayıları değişkenine aktarılır*/
                checkboxsayidizisi[0] = checkboxsayilari % 1000;/*pcnin tahmin ettiği sayının mod 1000 alınır ve moddan kalan dizi[0]'a aktarılır */
                checkboxsayidizisi[1] = checkboxsayilari - checkboxsayidizisi[0];/*pcnin tahmin ettiği sayı mod1000 alınmış değerinden çıkartılır */
                checkboxsayidizisi[2] = checkboxsayidizisi[1] / 1000;/*tahmin edilen sayının birinci basamağı bulunur*/






                checkboxsayidizisi[3] = checkboxsayidizisi[0] % 100;/*pcnin tahmin ettiği sayının mod 1000 den alındıktan sonra sayının kalan 3 basamağı ise mod 100 alınır"*/
                checkboxsayidizisi[4] = checkboxsayidizisi[0] - checkboxsayidizisi[3];/*pcnin tahmin ettiği sayı mod1000 mod 100 alınmış değerinden çıkartılır */
                checkboxsayidizisi[5] = checkboxsayidizisi[4] / 100;/*sayı yüze bölünerek 2.rakam bulunur*/
                checkboxsayidizisi[6] = checkboxsayidizisi[3] % 10;/*daha sonra 3 basamaklı sayı mod 10 alınarak */
                checkboxsayidizisi[7] = checkboxsayidizisi[3] - checkboxsayidizisi[6];/*daha sonra sayının 2 basamağı mod10 ile alınmış değerden çıkarılacak*/
                checkboxsayidizisi[8] = checkboxsayidizisi[7] / 10;/*sayı 10a bölünecekve sayının 3. basamağı bulunacak*/
                checkboxsayidizisi[9] = checkboxsayidizisi[6];/*sayının mod10a bölümünden sonra sayının 4. basamağı bulunacak*/

                label12.Text = checkboxsayidizisi[2].ToString();/*sayının birinici basamağı label12ye eşitlenecek*/
                label13.Text = checkboxsayidizisi[5].ToString();/*sayının ikinci basamağı label13e eşitlenecek*/
                label14.Text = checkboxsayidizisi[8].ToString();/*sayının üçüncü basamağı label14e eşitlenecek*/
                label15.Text = checkboxsayidizisi[9].ToString();/*sayının dördüncü basamağı label15e eşitlenecek*/
            
               }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (checkBox1.Checked == true)/* checkbox1 eşitse parantez içerisindeki şartlar sağlanacak*/
                    {
                        kttahmin[0] = Convert.ToInt32(label12.Text);/*checkboxda seçilene değer kttahmin[0]a eşit olacak*/

                        label16.Text = kttahmin[0].ToString();/*daha sonra label16ya yazdırılacak*/
                        syc9++;/*pcnin + puanı eklenecek*/
                        kttsycdzs[0] = syc9;/*eklenecek değerde ktsycdzs[0] akatarılacak*/

                    }


                    if (checkBox1.Checked != true)/*eşit değilse bu şart sağlanacak*/
                    {

                        syc13++;/*- puan artacak*/
                        kttsycdzs[4] = syc13;/*bu  - puan değeri kttsycdzs[4]'e aktarılacak*/

                    }





                    if (checkBox2.Checked == true)/* checkbox2 eşitse parantez içerisindeki şartlar sağlanacak*/
                    {
                        kttahmin[1] = Convert.ToInt32(label13.Text);/*checkboxda seçilene değer kttahmin[1]e eşit olacak*/
                        label17.Text = kttahmin[1].ToString();/*daha sonra label17ye yazdırılacak*/
                        syc10++;/*pcnin + puanı eklenecek*/
                        kttsycdzs[1] = syc10;/*eklenecek değerde ktsycdzs[1]e akatarılacak*/
                    }
                    if (checkBox2.Checked != true)/*eşit değilse bu şart sağlanacak**/
                    {

                        syc14++;/*- puan artacak*/
                        kttsycdzs[5] = syc14;/*bu  - puan değeri kttsycdzs[5]'e aktarılacak*/

                    }



                    if (checkBox3.Checked == true)/* checkbox3 eşitse parantez içerisindeki şartlar sağlanacak*/
                    {
                        kttahmin[2] = Convert.ToInt32(label14.Text);/*checkboxda seçilene değer kttahmin[2]e eşit olacak*/
                        label18.Text = kttahmin[2].ToString();/*daha sonra label18e yazdırılacak*/
                        syc11++;/*pcnin + puanı eklenecek*/
                        kttsycdzs[2] = syc11;/*eklenecek değerde ktsycdzs[2]e akatarılacak*/
                    }

                    if (checkBox3.Checked != true)/*eşit değilse bu şart sağlanacak*/
                    {

                        syc15++;/*- puan artacak*/
                        kttsycdzs[6] = syc15;/*bu  - puan değeri kttsycdzs[6]'ya aktarılacak*/

                    }
                    if (checkBox4.Checked == true)/* checkbox4 eşitse parantez içerisindeki şartlar sağlanacak*/
                    {
                        kttahmin[3] = Convert.ToInt32(label15.Text);/*checkboxda seçilene değer kttahmin[3]e eşit olacak*/
                        label19.Text = kttahmin[3].ToString();/*daha sonra label19a yazdırılacak*/
                        syc12++;/*pcnin + puanı eklenecek*/
                        kttsycdzs[3] = syc12;/*eklenecek değerde ktsycdzs[3]e akatarılacak*/
                    }

                    if (checkBox4.Checked != true)/*eşit değilse bu şart sağlanacak*/
                    {

                        syc16++;/*- puan artacak*/
                        kttsycdzs[7] = syc16;/*bu  - puan değeri kttsycdzs[7]'ye aktarılacak*/

                    }




                    label24.Text = ((kttsycdzs[0] + kttsycdzs[1] + kttsycdzs[2] + kttsycdzs[3]).ToString());/*toplam + puan buraya yazılacak ve burada toplanacak.Toplanan sayılar string tipinden olacak ve label24'e eşit olacak*/

                    label25.Text = (((-1) * (kttsycdzs[4] + kttsycdzs[5] + kttsycdzs[6] + kttsycdzs[7])).ToString());/*toplam - puan buraya yazılacak ve burada toplanacak.Toplanan sayılar string tipinden olacak ve label25'e eşit olacak*/
           
            }
            catch (Exception k)
            {
                MessageBox.Show("sayı üretilmeden girme hata verir");
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult deneme = MessageBox.Show("çıkış yapılsın mı", "uyarı penceresi", MessageBoxButtons.YesNo);
            if (deneme == DialogResult.Yes)
            {
                MessageBox.Show("çıkış yapılıyor");
                Environment.Exit(0);
            }
           
          
        }
    }
}

