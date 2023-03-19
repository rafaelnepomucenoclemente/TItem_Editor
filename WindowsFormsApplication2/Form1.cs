using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Encoding enc;
        private byte[] Bytes;
        private uint[] Uint32;
        
        private string[] String1S;
       // private string[] bGroupPoint;
        //
        private ushort[] wSkillID;
        private byte[] new1;
        private byte[] new2;
        private byte[] new3;
        private byte[] new4;
        private byte[] new5;
        private byte[] new6;
        private byte[] new7;
        private byte[] new8;
        private byte[] new9;
        private byte[] new10;
        private byte[] new11;
        private byte[] new12;
        private byte[] new13;
        private byte[] new14;
        private byte[] new15;
        private byte[] new16;
        private byte[] new17;
        private byte[] typ;
        private byte[] kind;
        private ushort[] AttrID;
        private string[] name;
        private ushort[] usevalue;
        private uint[] SlotID2;
        private uint[] ClassID2;
        private byte[] SubSlotID2;
        private byte[] level2;
        private byte[] canRepair2;
        private uint[] dwDuraMax1;
        private byte[] refinemax;
        private float[] PriceRate;
        private uint[] price;
        private byte[] MinRange;
        private byte[] MaxRange;
        private byte[] bStack;
        private byte[] SlotCount;
        private byte[] CanGamble;
        private byte[] GambleProb;
        private byte[] DestroyProb;
        private byte[] cangrade;
        private byte[] canmagic;
        private byte[] PrmSlot;
        private byte[] canrare;
        private ushort[] DelayGroupID;
        private uint[] delay;
        private byte[] cantrade;
        private byte[] isspecial;
        private ushort[] Usetime;
        private byte[] usetype;
        private byte[] weaponid;
        private float[] ShotSpeed;
        private float[] Gravity;
        private uint[] dwInfoID;
        private byte[] SkillItemType;
        private ushort[] Visual1;
        private ushort[] Visual2;
        private ushort[] Visual3;
        private ushort[] Visual4;
        private ushort[] Visual5;
        private ushort[] GradeSFX;
        private ushort[] optionSFX1;
        private ushort[] optionSFX2;
        private ushort[] optionSFX3;
        private byte[] canWrap;
        private uint[] AuctionCode;
        private byte[] canColor;
        //

        private int[] String1längeI;
        private ulong AnzahlNPC;
        public Form1()
        {

            base.Load += new EventHandler(this.Form1_Load);
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            this.enc = Encoding.Default;
            this.InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenFileDialog1.Filter = "TCD Файлы (*.tcd)|*.tcd|Все Файлы (*.*)|*.*";
            this.OpenFileDialog1.Title = "Открыть TCD";
            this.OpenFileDialog1.FileName = "";
            if (this.OpenFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Computer myComputer = new Computer();
            this.Bytes = myComputer.FileSystem.ReadAllBytes(this.OpenFileDialog1.FileName);
            this.Laden();
        }

        private void ReDims()
        {
            ushort num = (ushort)50000;
            this.Uint32 = new uint[checked((int)num + 300 + 1)];
            this.String1S = new string[checked((int)num + 300 + 1)];
            this.String1längeI = new int[checked((int)num + 300 + 1)];


            this.wSkillID = new ushort[checked((int)num + 300 + 1)];
            this.new1 = new byte[checked((int)num + 300 + 1)];
            this.new3 = new byte[checked((int)num + 300 + 1)];
            this.name = new string[checked((int)num + 300 + 1)];
            this.new2 = new byte[checked((int)num + 300 + 1)];
            this.new4 = new byte[checked((int)num + 300 + 1)];
             this.new5 = new byte[checked((int)num + 300 + 1)];
    
             this.new6 = new byte[checked((int)num + 300 + 1)];
    
             this.new7 = new byte[checked((int)num + 300 + 1)];
             this.new8 = new byte[checked((int)num + 300 + 1)];
             this.new9 = new byte[checked((int)num + 300 + 1)];
             this.new10 = new byte[checked((int)num + 300 + 1)];


             this.new11 = new byte[checked((int)num + 300 + 1)];
             this.new12 = new byte[checked((int)num + 300 + 1)];

             this.new13 = new byte[checked((int)num + 300 + 1)];

             this.new14 = new byte[checked((int)num + 300 + 1)];
             this.new15 = new byte[checked((int)num + 300 + 1)];
             this.new16 = new byte[checked((int)num + 300 + 1)];
             this.new17 = new byte[checked((int)num + 300 + 1)];
            this.typ = new byte[checked((int)num + 300 + 1)];
            this.kind = new byte[checked((int)num + 300 + 1)];
     this.AttrID = new ushort[checked((int)num + 300 + 1)];
            
      this.usevalue = new ushort[checked((int)num + 300 + 1)];
        this.SlotID2 = new uint[checked((int)num + 300 + 1)];
       this.ClassID2 = new uint[checked((int)num + 300 + 1)];
                 this.PrmSlot = new byte[checked((int)num + 300 + 1)];
                 this.SubSlotID2 = new byte[checked((int)num + 300 + 1)];
                 this.level2 = new byte[checked((int)num + 300 + 1)];
                 this.canRepair2 = new byte[checked((int)num + 300 + 1)];
         this.dwDuraMax1 = new uint[checked((int)num + 300 + 1)];
   this.refinemax = new byte[checked((int)num + 300 + 1)];
             this.PriceRate = new float[checked((int)num + 300 + 1)];
      this.price = new uint[checked((int)num + 300 + 1)];
             this.MinRange = new byte[checked((int)num + 300 + 1)];
             this.MaxRange = new byte[checked((int)num + 300 + 1)];
             this.bStack = new byte[checked((int)num + 300 + 1)];
             this.SlotCount = new byte[checked((int)num + 300 + 1)]; //30
             this.CanGamble = new byte[checked((int)num + 300 + 1)];
             this.GambleProb = new byte[checked((int)num + 300 + 1)];
             this.DestroyProb = new byte[checked((int)num + 300 + 1)];
             this.cangrade = new byte[checked((int)num + 300 + 1)];
             this.canmagic = new byte[checked((int)num + 300 + 1)];
         this.canrare = new byte[checked((int)num + 300 + 1)];
             this.DelayGroupID = new ushort[checked((int)num + 300 + 1)];
         this.delay = new uint[checked((int)num + 300 + 1)];
        this.cantrade = new byte[checked((int)num + 300 + 1)];
              this.isspecial = new byte[checked((int)num + 300 + 1)];
       this.Usetime = new ushort[checked((int)num + 300 + 1)];
              this.usetype = new byte[checked((int)num + 300 + 1)];
              this.weaponid = new byte[checked((int)num + 300 + 1)];
                          this.ShotSpeed = new float[checked((int)num + 300 + 1)];
                          this.Gravity = new float[checked((int)num + 300 + 1)];
             this.dwInfoID = new uint[checked((int)num + 300 + 1)];
            this.SkillItemType = new byte[checked((int)num + 300 + 1)];
         this.Visual1 = new ushort[checked((int)num + 300 + 1)];
              this.Visual2 = new ushort[checked((int)num + 300 + 1)];
              this.Visual3 = new ushort[checked((int)num + 300 + 1)];
              this.Visual4 = new ushort[checked((int)num + 300 + 1)];
              this.Visual5 = new ushort[checked((int)num + 300 + 1)];
              this.GradeSFX = new ushort[checked((int)num + 300 + 1)];
              this.optionSFX1 = new ushort[checked((int)num + 300 + 1)];
              this.optionSFX2 = new ushort[checked((int)num + 300 + 1)];
              this.optionSFX3 = new ushort[checked((int)num + 300 + 1)];
         this.canWrap = new byte[checked((int)num + 300 + 1)];
             this.AuctionCode = new uint[checked((int)num + 300 + 1)];
              this.canColor = new byte[checked((int)num + 300 + 1)];

  /*          this.dwInven = new uint[checked((int)num + 300 + 1)];
            this.ObjectID = new uint[checked((int)num + 300 + 1)];
            this.CLKID = new uint[checked((int)num + 300 + 1)];
            this.CLIID = new uint[checked((int)num + 300 + 1)];
            this.Mesh1 = new uint[checked((int)num + 300 + 1)];
            this.Mesh2 = new uint[checked((int)num + 300 + 1)];
            this.Mesh3 = new uint[checked((int)num + 300 + 1)];
            this.Pivot1 = new uint[checked((int)num + 300 + 1)];
            this.Pivot2 = new uint[checked((int)num + 300 + 1)];
            this.Pivot3 = new uint[checked((int)num + 300 + 1)];
            this.SlashColor = new uint[checked((int)num + 300 + 1)];
            this.SlashTex = new uint[checked((int)num + 300 + 1)];
            this.EffectFunc = new uint[checked((int)num + 300 + 1)];
            this.EffectFunc2 = new uint[checked((int)num + 300 + 1)];
            this.CostumeHide = new uint[checked((int)num + 300 + 1)];

            this.bPrevLevel = new ushort[checked((int)num + 300 + 1)];
        //    this.bLevel = new ushort[checked((int)num + 300 + 1)];
            this.x = new float[checked((int)num + 300 + 1)];
      //      this.z = new float[checked((int)num + 300 + 1)];
   * */

        }

        private void Speichern()
        {
            this.SaveFileDialog1.Filter = "TCD Файлы (*.tcd)|*.tcd|Все файлы (*.*)|*.*";
            this.SaveFileDialog1.Title = "Сохранить TCD";
            this.SaveFileDialog1.FileName = "";
            if (this.SaveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(this.SaveFileDialog1.FileName, FileMode.Create),Encoding.Default);
      //      int index1 = 0;
            int index2 = 0;
            binaryWriter.Write(this.AnzahlNPC);
            while (index2 != (int)this.AnzahlNPC)
            {










                binaryWriter.Write(this.name[index2]);
                binaryWriter.Write(this.wSkillID[index2]);
                binaryWriter.Write(this.typ[index2]);
                binaryWriter.Write(this.kind[index2]);
                binaryWriter.Write(this.AttrID[index2]);
               
                binaryWriter.Write(this.usevalue[index2]);
                binaryWriter.Write(this.SlotID2[index2]);
                binaryWriter.Write(this.ClassID2[index2]);
                binaryWriter.Write(this.PrmSlot[index2]);
                binaryWriter.Write(this.SubSlotID2[index2]); //10
                binaryWriter.Write(this.level2[index2]);
                binaryWriter.Write(this.canRepair2[index2]);
                binaryWriter.Write(this.dwDuraMax1[index2]);
                binaryWriter.Write(this.refinemax[index2]);
                binaryWriter.Write(this.PriceRate[index2]);
                binaryWriter.Write(this.price[index2]);
                binaryWriter.Write(this.MinRange[index2]);
                binaryWriter.Write(this.MaxRange[index2]);
                binaryWriter.Write(this.bStack[index2]);
                binaryWriter.Write(this.SlotCount[index2]);//20
                binaryWriter.Write(this.CanGamble[index2]);
                binaryWriter.Write(this.GambleProb[index2]);
                binaryWriter.Write(this.DestroyProb[index2]);
                binaryWriter.Write(this.new1[index2]);
                binaryWriter.Write(this.new2[index2]);
                binaryWriter.Write(this.cangrade[index2]);
                binaryWriter.Write(this.canmagic[index2]);
                binaryWriter.Write(this.canrare[index2]);
                binaryWriter.Write(this.DelayGroupID[index2]);
                binaryWriter.Write(this.delay[index2]);//30
                binaryWriter.Write(this.cantrade[index2]);
                binaryWriter.Write(this.isspecial[index2]);
                binaryWriter.Write(this.Usetime[index2]);
                binaryWriter.Write(this.usetype[index2]);
                binaryWriter.Write(this.new3[index2]);
                binaryWriter.Write(this.weaponid[index2]);
                binaryWriter.Write(this.ShotSpeed[index2]);
                binaryWriter.Write(this.Gravity[index2]);
                binaryWriter.Write(this.dwInfoID[index2]);
                binaryWriter.Write(this.SkillItemType[index2]);//40
                binaryWriter.Write(this.Visual1[index2]);
                binaryWriter.Write(this.Visual2[index2]);
                binaryWriter.Write(this.Visual3[index2]);
                binaryWriter.Write(this.Visual4[index2]);
                binaryWriter.Write(this.Visual5[index2]);
                binaryWriter.Write(this.GradeSFX[index2]);
                binaryWriter.Write(this.optionSFX1[index2]);
                binaryWriter.Write(this.optionSFX2[index2]);
                binaryWriter.Write(this.optionSFX3[index2]);
                binaryWriter.Write(this.canWrap[index2]);//50
                binaryWriter.Write(this.AuctionCode[index2]);
                binaryWriter.Write(this.canColor[index2]);
                binaryWriter.Write(this.new4[index2]);
                binaryWriter.Write(this.new5[index2]);
                binaryWriter.Write(this.new6[index2]);
                binaryWriter.Write(this.new7[index2]);
                binaryWriter.Write(this.new8[index2]);
                binaryWriter.Write(this.new9[index2]);
                binaryWriter.Write(this.new10[index2]);
                binaryWriter.Write(this.new11[index2]);
                binaryWriter.Write(this.new12[index2]);
                binaryWriter.Write(this.new13[index2]);
                binaryWriter.Write(this.new14[index2]);
                binaryWriter.Write(this.new15[index2]);
                binaryWriter.Write(this.new16[index2]);
                binaryWriter.Write(this.new17[index2]);


     

 
                checked { ++index2; }
            }
            binaryWriter.Close();
            int num = (int)Interaction.MsgBox((object)"Сохранено", MsgBoxStyle.OkOnly, (object)null);
        }

        private void Laden()
        {
         // StreamReader   new StreamReader(@"E:\database.txt", System.Text.Encoding.Default));
            BinaryReader binaryReader = new BinaryReader((Stream)new MemoryStream(this.Bytes),Encoding.Default);
            int index1 = 0;
       //     int num = 0;
            binaryReader.BaseStream.Position = 0L;
            this.AnzahlNPC = binaryReader.ReadUInt16();
            this.ReDims();
            while (index1 != (int)this.AnzahlNPC)
            {
               // int index2 = 0;


  
                this.wSkillID[index1] = binaryReader.ReadUInt16();
                  this.typ[index1] = binaryReader.ReadByte();
                 this.kind[index1] = binaryReader.ReadByte();
                 this.AttrID[index1] = binaryReader.ReadUInt16();
                 this.name[index1] = binaryReader.ReadString();
                  this.usevalue[index1] = binaryReader.ReadUInt16();
                 this.SlotID2[index1] = binaryReader.ReadUInt32();
                 this.ClassID2[index1] = binaryReader.ReadUInt32();
                this.PrmSlot[index1] = binaryReader.ReadByte();
                 this.SubSlotID2[index1] = binaryReader.ReadByte();
                 this.level2[index1] = binaryReader.ReadByte();
                 this.canRepair2[index1] = binaryReader.ReadByte();
                  this.dwDuraMax1[index1] = binaryReader.ReadUInt32();
                        this.refinemax[index1] = binaryReader.ReadByte();
                        this.PriceRate[index1] = binaryReader.ReadSingle();
                    this.price[index1] = binaryReader.ReadUInt32();
                                 this.MinRange[index1] = binaryReader.ReadByte();
                 this.MaxRange[index1] = binaryReader.ReadByte();
                     this.bStack[index1] = binaryReader.ReadByte();
                     this.SlotCount[index1] = binaryReader.ReadByte();
                  this.CanGamble[index1] = binaryReader.ReadByte();
                     this.GambleProb[index1] = binaryReader.ReadByte();
                      this.DestroyProb[index1] = binaryReader.ReadByte();
                this.new1[index1] = binaryReader.ReadByte();
                this.new2[index1] = binaryReader.ReadByte();
                 this.cangrade[index1] = binaryReader.ReadByte();
                this.canmagic[index1] = binaryReader.ReadByte();
                this.canrare[index1] = binaryReader.ReadByte();
                    this.DelayGroupID[index1] = binaryReader.ReadUInt16();
                      this.delay[index1] = binaryReader.ReadUInt32(); //30
                          this.cantrade[index1] = binaryReader.ReadByte();
                this.isspecial[index1] = binaryReader.ReadByte();
                    this.Usetime[index1] = binaryReader.ReadUInt16();
                   this.usetype[index1] = binaryReader.ReadByte();
                   this.new3[index1] = binaryReader.ReadByte();
                 this.weaponid[index1] = binaryReader.ReadByte();
                 this.ShotSpeed[index1] = binaryReader.ReadSingle();
                 this.Gravity[index1] = binaryReader.ReadSingle();
                     this.dwInfoID[index1] = binaryReader.ReadUInt32();
                  this.SkillItemType[index1] = binaryReader.ReadByte();
                   this.Visual1[index1] = binaryReader.ReadUInt16();
                   this.Visual2[index1] = binaryReader.ReadUInt16();
                   this.Visual3[index1] = binaryReader.ReadUInt16();
                   this.Visual4[index1] = binaryReader.ReadUInt16();
                   this.Visual5[index1] = binaryReader.ReadUInt16();
                   this.GradeSFX[index1] = binaryReader.ReadUInt16();
                   this.optionSFX1[index1] = binaryReader.ReadUInt16();
                     this.optionSFX2[index1] = binaryReader.ReadUInt16();
                     this.optionSFX3[index1] = binaryReader.ReadUInt16();
                     this.canWrap[index1] = binaryReader.ReadByte();
                                this.AuctionCode[index1] = binaryReader.ReadUInt32();
                   this.canColor[index1] = binaryReader.ReadByte();
                  this.new4[index1] = binaryReader.ReadByte();
                  this.new5[index1] = binaryReader.ReadByte();
                  this.new6[index1] = binaryReader.ReadByte();
                  this.new7[index1] = binaryReader.ReadByte();
                  this.new8[index1] = binaryReader.ReadByte();
                  this.new9[index1] = binaryReader.ReadByte();
                  this.new10[index1] = binaryReader.ReadByte();
                  this.new11[index1] = binaryReader.ReadByte();
                  this.new12[index1] = binaryReader.ReadByte();
                  this.new13[index1] = binaryReader.ReadByte();
                  this.new14[index1] = binaryReader.ReadByte();
                  this.new15[index1] = binaryReader.ReadByte();
                  this.new16[index1] = binaryReader.ReadByte();
                  this.new17[index1] = binaryReader.ReadByte();
                /*
                 this.dwInven[index1] = binaryReader.ReadUInt32();
                 this.ObjectID[index1] = binaryReader.ReadUInt32();
                               this.CLKID[index1] = binaryReader.ReadUInt32();
                                 this.CLIID[index1] = binaryReader.ReadUInt32();
                                 this.Mesh1[index1] = binaryReader.ReadUInt32();
                                 this.Mesh2[index1] = binaryReader.ReadUInt32();
                              //   this.Mesh3[index1] = binaryReader.ReadUInt32();
                                 this.Pivot1[index1] = binaryReader.ReadUInt32();
                                 this.Pivot2[index1] = binaryReader.ReadUInt32();
                            //     this.Pivot3[index1] = binaryReader.ReadUInt32();
                                 this.bPrevLevel[index1] = binaryReader.ReadUInt16();
                                 this.new1[index1] = binaryReader.ReadByte();
                                 this.new2[index1] = binaryReader.ReadByte();
                                 this.new3[index1] = binaryReader.ReadByte();
                                 this.SlashColor[index1] = binaryReader.ReadUInt32();
                                 this.SlashTex[index1] = binaryReader.ReadUInt32();
                                 this.x[index1] = binaryReader.ReadSingle();
                                 this.EffectFunc[index1] = binaryReader.ReadUInt32();
                                 this.EffectFunc2[index1] = binaryReader.ReadUInt32();
                                 this.CostumeHide[index1] = binaryReader.ReadUInt32();
               // this.bGroupPoint[index1] = binaryReader.ReadString();
          
                            

              //  this.bLevel[index1] = binaryReader.ReadUInt16();
              
               // this.z[index1] = binaryReader.ReadSingle();
                */                
   


 
   


                checked { ++index1; }
            }
            this.AnzahlNPC = checked((ulong)index1);
            this.Listen();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Speichern();
        }

        private void InsertinBox(int PortalZahl)
        {
         /*
          =================================================== */

      
       
       

           
            ////////////////////////////////////////////////////////////////////////


       

            
           
          


         



         //   this.GroupPoint.Text = Conversions.ToString((string)this.bGroupPoint[PortalZahl]);
       
//            byte[] bytes = Encoding.Default.GetBytes(bGroupPoint[PortalZahl]);
            /*
               
           
                   
                          
                             
                                 //   this.Mesh3[index1] = binaryReader.ReadUInt32();
                          
                               //     this.Pivot3[index1] = binaryReader.ReadUInt32();
                               
                                
                                 
                                
                                    
                                    this.EffectFunc[index1] = binaryReader.ReadUInt32();
                                    this.EffectFunc2[index1] = binaryReader.ReadUInt32();
                                 
             * */
            this.xko.Text = Conversions.ToString((string)this.name[PortalZahl]);
            this.SkillID.Text = Conversions.ToString((ushort)this.wSkillID[PortalZahl]);
            this.GroupPoint.Text = Conversions.ToString((byte)this.typ[PortalZahl]);
            this.funkc.Text = Conversions.ToString((float)this.PriceRate[PortalZahl]);
            this.textBox2.Text = Conversions.ToString((byte)this.kind[PortalZahl]);
            this.textBox3.Text = Conversions.ToString((UInt16)this.AttrID[PortalZahl]);
  
            this.textBox4.Text = Conversions.ToString((UInt32)this.SlotID2[PortalZahl]);
            this.textBox11.Text = Conversions.ToString((UInt32)this.delay[PortalZahl]);
            this.textBox46.Text = Conversions.ToString((UInt16)this.DelayGroupID[PortalZahl]);
            this.funkce.Text = Conversions.ToString((UInt32)this.price[PortalZahl]);
            this.SkillPoint.Text = Conversions.ToString((UInt32)this.ClassID2[PortalZahl]);
            this.textBox18.Text = Conversions.ToString((UInt32)this.dwInfoID[PortalZahl]);
            this.textBox31.Text = Conversions.ToString((UInt32)this.AuctionCode[PortalZahl]);
            this.pivo.Text = Conversions.ToString((UInt32)this.dwDuraMax1[PortalZahl]);
           
            this.zko.Text = Conversions.ToString((UInt16)this.usevalue[PortalZahl]);
            this.textBox25.Text = Conversions.ToString((UInt16)this.Visual1[PortalZahl]);
            this.textBox24.Text = Conversions.ToString((UInt16)this.Visual2[PortalZahl]);
            this.textBox23.Text = Conversions.ToString((UInt16)this.Visual3[PortalZahl]);
            this.textBox22.Text = Conversions.ToString((UInt16)this.Visual4[PortalZahl]);
            this.textBox21.Text = Conversions.ToString((UInt16)this.Visual5[PortalZahl]);
            this.textBox20.Text = Conversions.ToString((float)this.Gravity[PortalZahl]);
            this.textBox19.Text = Conversions.ToString((float)this.ShotSpeed[PortalZahl]);
            this.textBox16.Text = Conversions.ToString((UInt16)this.Usetime[PortalZahl]);
            this.textBox27.Text = Conversions.ToString((UInt16)this.optionSFX1[PortalZahl]);
            this.textBox29.Text = Conversions.ToString((UInt16)this.optionSFX2[PortalZahl]);
            this.textBox28.Text = Conversions.ToString((UInt16)this.optionSFX3[PortalZahl]);
            this.textBox26.Text = Conversions.ToString((UInt16)this.GradeSFX[PortalZahl]);

            //
            this.textBox41.Text = Conversions.ToString((byte)this.new1[PortalZahl]);
            this.textBox42.Text = Conversions.ToString((byte)this.new2[PortalZahl]);
            this.textBox37.Text = Conversions.ToString((byte)this.new3[PortalZahl]);
            this.textBox38.Text = Conversions.ToString((byte)this.new4[PortalZahl]);
            this.textBox39.Text = Conversions.ToString((byte)this.new5[PortalZahl]);
            this.textBox34.Text = Conversions.ToString((byte)this.new6[PortalZahl]);
            this.textBox36.Text = Conversions.ToString((byte)this.new7[PortalZahl]);
            this.textBox35.Text = Conversions.ToString((byte)this.new8[PortalZahl]);
            this.textBox33.Text = Conversions.ToString((byte)this.new9[PortalZahl]);
            this.textBox40.Text = Conversions.ToString((byte)this.new10[PortalZahl]);
            this.kostym.Text = Conversions.ToString((byte)this.PrmSlot[PortalZahl]);
            this.textBox45.Text = Conversions.ToString((byte)this.SubSlotID2[PortalZahl]);
            this.mesh.Text = Conversions.ToString((byte)this.level2[PortalZahl]);
            this.meshik.Text = Conversions.ToString((byte)this.canRepair2[PortalZahl]);
            this.pivot.Text = Conversions.ToString((byte)this.refinemax[PortalZahl]);
            this.textBox5.Text = Conversions.ToString((byte)this.MinRange[PortalZahl]);
            this.slot.Text = Conversions.ToString((byte)this.MaxRange[PortalZahl]);
            this.scolo.Text = Conversions.ToString((byte)this.bStack[PortalZahl]);
            this.textBox44.Text = Conversions.ToString((byte)this.SlotCount[PortalZahl]);
            this.textBox43.Text = Conversions.ToString((byte)this.CanGamble[PortalZahl]);
            this.textBox13.Text = Conversions.ToString((byte)this.GambleProb[PortalZahl]);
            this.textBox7.Text = Conversions.ToString((byte)this.DestroyProb[PortalZahl]);
            this.textBox8.Text = Conversions.ToString((byte)this.cangrade[PortalZahl]);
            this.textBox10.Text = Conversions.ToString((byte)this.canmagic[PortalZahl]);
            this.textBox9.Text = Conversions.ToString((byte)this.canrare[PortalZahl]);
            this.textBox6.Text = Conversions.ToString((byte)this.cantrade[PortalZahl]);
            this.textBox15.Text = Conversions.ToString((byte)this.isspecial[PortalZahl]);
            this.textBox14.Text = Conversions.ToString((byte)this.usetype[PortalZahl]);
            this.textBox12.Text = Conversions.ToString((byte)this.weaponid[PortalZahl]);
            this.textBox30.Text = Conversions.ToString((byte)this.canWrap[PortalZahl]);
            this.textBox32.Text = Conversions.ToString((byte)this.canColor[PortalZahl]);
            this.textBox17.Text = Conversions.ToString((byte)this.SkillItemType[PortalZahl]);
            this.textBox47.Text = Conversions.ToString((byte)this.new11[PortalZahl]);
            this.textBox48.Text = Conversions.ToString((byte)this.new12[PortalZahl]);
            this.textBox49.Text = Conversions.ToString((byte)this.new13[PortalZahl]);
            this.textBox50.Text = Conversions.ToString((byte)this.new14[PortalZahl]);
            this.textBox51.Text = Conversions.ToString((byte)this.new15[PortalZahl]);
            this.textBox52.Text = Conversions.ToString((byte)this.new16[PortalZahl]);
            this.textBox53.Text = Conversions.ToString((byte)this.new17[PortalZahl]);
       
            /*
            //  this.S   bGroupPoint = Encoding.UTF8.GetString(bytes[0]);killPoint.Text = Conversions.ToString((byte)this.bSkillPoint[PortalZahl]);
           this.textBox5.Text = Conversions.ToString((ushort)this.bPrevLevel[PortalZahl]);
           // this.textBox3.Text = Conversions.ToString((ushort)this.bLevel[PortalZahl]);
            this.zko.Text = Conversions.ToString((float)this.x[PortalZahl]);
         //   this.zko.Text = Conversions.ToString((float)this.z[PortalZahl]);
            this.slot.Text = Conversions.ToString((byte)this.new1[PortalZahl]);
            this.SkillPoint.Text = Conversions.ToString((byte)this.new3[PortalZahl]);
            this.GroupPoint.Text = Conversions.ToString((uint)this.dwInven[PortalZahl]);
            this.mesh.Text = Conversions.ToString((uint)this.Mesh1[PortalZahl]);
            this.meshik.Text = Conversions.ToString((uint)this.Mesh2[PortalZahl]);
            this.pivo.Text = Conversions.ToString((uint)this.Pivot1[PortalZahl]);
            this.pivot.Text = Conversions.ToString((uint)this.Pivot2[PortalZahl]);
            this.textBox2.Text = Conversions.ToString((uint)this.ObjectID[PortalZahl]);
            this.textBox3.Text = Conversions.ToString((uint)this.CLKID[PortalZahl]);
            this.textBox2.Text = Conversions.ToString((uint)this.ObjectID[PortalZahl]);
            this.xko.Text = Conversions.ToString((uint)this.CLIID[PortalZahl]);
            this.textBox13.Text = Conversions.ToString((uint)this.SlashTex[PortalZahl]);
            this.scolo.Text = Conversions.ToString((uint)this.SlashColor[PortalZahl]);
            this.textBox4.Text = Conversions.ToString((byte)this.new2[PortalZahl]);
            this.kostym.Text = Conversions.ToString((uint)this.CostumeHide[PortalZahl]);
            this.funkc.Text = Conversions.ToString((uint)this.EffectFunc[PortalZahl]);
            this.funkce.Text = Conversions.ToString((uint)this.EffectFunc2[PortalZahl]);
         
          */

        }

        private void Listen()
        {
            for (string str = Conversions.ToString(0); (double)this.AnzahlNPC >= Conversions.ToDouble(str) + 1.0; str = Conversions.ToString(Conversions.ToDouble(str) + 1.0))
                this.listBox1.Items.Add((object)(str + ": " + this.name[Conversions.ToInteger(str)]));
        }

        private void listBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string[] strArray = new string[11];
            this.InsertinBox(Conversions.ToInteger(((string[])NewLateBinding.LateGet(this.listBox1.SelectedItem, (System.Type)null, "Split", new object[1]
      {
        (object) Convert.ToChar(":")
      }, (string[])null, (System.Type[])null, (bool[])null))[0]));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] strArray = new string[21];
            string str = ((string[])NewLateBinding.LateGet(this.listBox1.SelectedItem, (System.Type)null, "Split", new object[1]
      {
        (object) Convert.ToChar(":")
      }, (string[])null, (System.Type[])null, (bool[])null))[0];
           //
            /*
             *     this.wSkillID[Conversions.ToInteger(str)] = Conversions.ToUShort(this.SkillID.Text);
                this.dwInven[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.GroupPoint.Text);
                this.ObjectID[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.textBox2.Text);
                this.CLKID[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.textBox3.Text);
                this.CLIID[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.xko.Text);
                this.Mesh1[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.mesh.Text);
                this.Mesh2[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.meshik.Text);
                this.Pivot1[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.pivo.Text);
                this.Pivot2[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.pivot.Text);
                this.bPrevLevel[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox5.Text);
                this.new1[Conversions.ToInteger(str)] = Conversions.ToByte(this.slot.Text);
                this.new2[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox4.Text);
                this.new3[Conversions.ToInteger(str)] = Conversions.ToByte(this.SkillPoint.Text);
                this.SlashColor[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.scolo.Text);
                this.SlashTex[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.textBox13.Text);
                this.x[Conversions.ToInteger(str)] = Conversions.ToSingle(this.zko.Text);
                this.EffectFunc[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.funkc.Text);
                this.EffectFunc2[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.funkce.Text);
            
              
             
               
              
                 
                 this.CostumeHide[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.kostym.Text);
             * */
     
            int num = (int)Interaction.MsgBox((object)"Сохранить", MsgBoxStyle.Information, (object)null);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Add_NPC();
        }

        public void Add_NPC()
        {
            this.AnzahlNPC = checked((ushort)((int)this.AnzahlNPC + 1));
            this.listBox1.Items.Add((object)(Conversions.ToString(checked((int)this.AnzahlNPC - 1)) + ": " + this.String1S[checked((int)this.AnzahlNPC - 1)]));
        }

        private void listBox2_SelectedValueChanged_1(object sender, EventArgs e)
        {
            string[] strArray = new string[11];
            this.InsertinBox(Conversions.ToInteger(((string[])NewLateBinding.LateGet(this.listBox2.SelectedItem, (System.Type)null, "Split", new object[1]
      {
        (object) Convert.ToChar(":")
      }, (string[])null, (System.Type[])null, (bool[])null))[0]));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox2.Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (Operators.CompareString(this.textBox1.Text, "", false) == 0)
            {
                this.listBox1.Show();
                this.listBox2.Hide();
            }
            else
            {
                this.listBox2.Items.Clear();
                try
                {
                    foreach (object obj1 in this.listBox1.Items)
                    {
                        object objectValue = RuntimeHelpers.GetObjectValue(obj1);
                        object Instance = objectValue;
                        // ISSUE: variable of the null type
                        object local1 = null;
                        string MemberName = "Contains";
                        object[] objArray1 = new object[1];
                        object[] objArray2 = objArray1;
                        int index = 0;
                        TextBox textBox1 = this.textBox1;
                        string text = textBox1.Text;
                        objArray2[index] = (object)text;
                        object[] objArray3 = objArray1;
                        object[] Arguments = objArray3;
                        // ISSUE: variable of the null type
                        object local2 = null;
                        // ISSUE: variable of the null type
                        object local3 = null;
                        bool[] flagArray = new bool[1]
            {
              true
            };
                        bool[] CopyBack = flagArray;
                        object obj2 = NewLateBinding.LateGet(Instance, (System.Type)local1, MemberName, Arguments, (string[])local2, (System.Type[])local3, CopyBack);
                        if (flagArray[0])
                            textBox1.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray3[0]), typeof(string));
                        if (Conversions.ToBoolean(obj2))
                            this.listBox2.Items.Add(RuntimeHelpers.GetObjectValue(objectValue));
                    }
                }
                finally
                {
                    IEnumerator enumerator = null;
                    if (enumerator is IDisposable)
                        (enumerator as IDisposable).Dispose();
                }
                if (this.listBox2.Items.Count < 1)
                    return;
                this.listBox2.Show();
                this.listBox1.Hide();
            }
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void smazatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AnzahlNPC = checked((ushort)((int)this.AnzahlNPC - 1));
            
            this.listBox1.Items.Remove((object)(Conversions.ToString(checked((int)this.AnzahlNPC - 1)) + ": " + this.String1S[checked((int)this.AnzahlNPC - 1)]));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkillPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void xko_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] strArray = new string[21];
            string str = ((string[])NewLateBinding.LateGet(this.listBox1.SelectedItem, (System.Type)null, "Split", new object[1]
      {
        (object) Convert.ToChar(":")
      }, (string[])null, (System.Type[])null, (bool[])null))[0];

            this.wSkillID[Conversions.ToInteger(str)] = Conversions.ToUShort(this.SkillID.Text);
            this.typ[Conversions.ToInteger(str)] = Conversions.ToByte(this.GroupPoint.Text);
            this.kind[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox2.Text);
            this.AttrID[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox3.Text);
            this.name[Conversions.ToInteger(str)] = Conversions.ToString(this.xko.Text);
            this.usevalue[Conversions.ToInteger(str)] = Conversions.ToUShort(this.zko.Text);
            this.SlotID2[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.textBox4.Text);
            this.ClassID2[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.SkillPoint.Text);
            this.PrmSlot[Conversions.ToInteger(str)] = Conversions.ToByte(this.kostym.Text);
            this.SubSlotID2[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox45.Text);
            this.level2[Conversions.ToInteger(str)] = Conversions.ToByte(this.mesh.Text);
            this.canRepair2[Conversions.ToInteger(str)] = Conversions.ToByte(this.meshik.Text);
            this.dwDuraMax1[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.pivo.Text);
            this.refinemax[Conversions.ToInteger(str)] = Conversions.ToByte(this.pivot.Text);
            this.PriceRate[Conversions.ToInteger(str)] = Conversions.ToSingle(this.funkc.Text);
            this.price[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.funkce.Text);
            this.MinRange[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox5.Text);
            this.MaxRange[Conversions.ToInteger(str)] = Conversions.ToByte(this.slot.Text);
            this.bStack[Conversions.ToInteger(str)] = Conversions.ToByte(this.scolo.Text);
            this.SlotCount[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox44.Text);
            this.CanGamble[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox43.Text);
            this.GambleProb[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox13.Text);
            this.DestroyProb[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox7.Text);
            this.new1[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox41.Text);
            this.new2[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox42.Text);
            this.cangrade[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox8.Text);
            this.canmagic[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox10.Text);
            this.canrare[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox9.Text);
            this.DelayGroupID[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox46.Text);
            this.delay[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.textBox11.Text); //10
            this.cantrade[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox6.Text);
            this.isspecial[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox15.Text);
            this.Usetime[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox16.Text);
            this.usetype[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox14.Text);
            this.new3[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox37.Text);
            this.weaponid[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox12.Text);
            this.ShotSpeed[Conversions.ToInteger(str)] = Conversions.ToSingle(this.textBox19.Text);
            this.Gravity[Conversions.ToInteger(str)] = Conversions.ToSingle(this.textBox20.Text);
            this.dwInfoID[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.textBox18.Text);
            this.SkillItemType[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox17.Text);
            this.Visual1[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox25.Text);
            this.Visual2[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox24.Text);
            this.Visual3[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox23.Text);
            this.Visual4[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox22.Text);
            this.Visual5[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox21.Text);//20
            this.GradeSFX[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox26.Text);
            this.optionSFX1[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox27.Text);
            this.optionSFX2[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox29.Text);
            this.optionSFX3[Conversions.ToInteger(str)] = Conversions.ToUShort(this.textBox28.Text);
            this.canWrap[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox30.Text);
            this.AuctionCode[Conversions.ToInteger(str)] = Conversions.ToUInteger(this.textBox31.Text);
            this.canColor[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox32.Text);
            this.new4[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox38.Text);
            this.new5[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox39.Text);
            this.new6[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox34.Text);
            this.new7[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox36.Text);
            this.new8[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox35.Text);
            this.new9[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox33.Text);
            this.new10[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox40.Text);
            this.new11[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox47.Text);
            this.new12[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox48.Text);
            this.new13[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox49.Text);//40
            this.new14[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox50.Text);
            this.new15[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox51.Text);
            this.new16[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox52.Text);
            this.new17[Conversions.ToInteger(str)] = Conversions.ToByte(this.textBox53.Text);

            int num = (int)Interaction.MsgBox((object)"Сохранено", MsgBoxStyle.Information, (object)null);
        }

        }
    }

