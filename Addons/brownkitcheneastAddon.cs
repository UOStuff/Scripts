
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class brownkitcheneastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2883, 1, -3, 5}, {2884, 2, -3, 5}, {4100, 1, -3, 14}// 6	7	17	
			, {5627, -2, -3, 9}, {4158, 3, -3, 9}, {2449, -4, 1, 9}// 24	25	50	
			, {2430, -4, 1, 10}, {2513, -4, 1, 11}, {2431, -4, 3, 13}// 68	69	70	
			, {2540, -4, -1, 11}, {18320, 2, -2, 4}// 71	72	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new brownkitcheneastAddonDeed();
			}
		}

		[ Constructable ]
		public brownkitcheneastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 18177, -4, -3, 4, 2112, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 18177, -3, -3, 4, 2112, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 18177, -2, -3, 4, 2112, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 18177, -1, -3, 4, 2112, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 18177, 0, -3, 4, 2112, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 18177, 3, -3, 4, 2112, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 18177, 4, -3, 4, 2112, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1293, -4, -3, 9, 2112, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1293, -3, -3, 9, 2112, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1293, -2, -3, 9, 2112, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1293, -1, -3, 9, 2112, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1293, 0, -3, 9, 2112, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1293, 3, -3, 9, 2112, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1293, 4, -3, 9, 2112, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2604, 3, -3, 14, 2112, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2604, 4, -3, 15, 2112, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1179, 5, -3, 14, 1150, -1, "Refrigerator", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1801, 5, -3, 15, 1150, -1, "Refrigerator", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1801, 5, -3, 9, 1150, -1, "Refrigerator", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1801, 5, -3, 4, 1150, -1, "Refrigerator", 1);// 23
			AddComplexComponent( (BaseAddon) this, 7870, -4, -3, 16, 81, -1, "columbine", 1);// 26
			AddComplexComponent( (BaseAddon) this, 3332, -4, -3, 12, 0, -1, "leaves", 1);// 27
			AddComplexComponent( (BaseAddon) this, 4551, -4, -3, 9, 0, -1, "Potted Columbine", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2604, 0, -3, 10, 2112, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2604, -1, -3, 10, 2112, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2604, -2, -3, 10, 2112, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2604, -3, -3, 10, 2112, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 18177, -4, -2, 4, 2112, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 18177, -4, -1, 4, 2112, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 18177, -4, 0, 4, 2112, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 18177, -4, 1, 4, 2112, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 18177, -4, 2, 4, 2112, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1293, -4, 2, 5, 2112, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1293, -4, 1, 5, 2112, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1293, -4, 2, 9, 2112, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1293, -4, 1, 9, 2112, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1293, -4, 0, 9, 2112, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1293, -4, -1, 9, 2112, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1293, -4, -2, 9, 2112, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2612, -4, -2, 11, 2112, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2612, -4, -1, 12, 2112, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2612, -4, 0, 13, 2112, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2612, -4, 1, 13, 2112, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2612, -4, 2, 13, 2112, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 281, -5, 4, 12, 1150, -1, "oven", 1);// 51
			AddComplexComponent( (BaseAddon) this, 269, -5, 4, 4, 1150, -1, "Sink", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1801, -4, 3, 7, 1150, -1, "oven", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1801, -4, 4, 7, 1153, -1, "Oven settings", 1);// 54
			AddComplexComponent( (BaseAddon) this, 281, -5, 3, 12, 1150, -1, "oven", 1);// 55
			AddComplexComponent( (BaseAddon) this, 3859, -4, 3, 17, 1, -1, "dial", 1);// 56
			AddComplexComponent( (BaseAddon) this, 3859, -4, 4, 17, 1, -1, "dial", 1);// 57
			AddComplexComponent( (BaseAddon) this, 7027, -4, 4, 12, 957, -1, "burner", 1);// 58
			AddComplexComponent( (BaseAddon) this, 7027, -4, 3, 12, 957, -1, "burner", 1);// 59
			AddComplexComponent( (BaseAddon) this, 9232, -3, 3, 0, 1, -1, "door", 1);// 60
			AddComplexComponent( (BaseAddon) this, 9232, -3, 4, 0, 1, -1, "door", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1801, -4, 3, 4, 1150, -1, "Sink", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1801, -4, 4, 4, 1150, -1, "Sink", 1);// 63
			AddComplexComponent( (BaseAddon) this, 2468, -4, 4, 15, 1, -1, "oven settings", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2468, -4, 3, 15, 1, -1, "oven settings", 1);// 65
			AddComplexComponent( (BaseAddon) this, 7830, 6, -2, 21, 962, -1, "Refrigerator", 1);// 66
			AddComplexComponent( (BaseAddon) this, 7830, 6, -2, 15, 962, -1, "Refrigerator", 1);// 67

		}

		public brownkitcheneastAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class brownkitcheneastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new brownkitcheneastAddon();
			}
		}

		[Constructable]
		public brownkitcheneastAddonDeed()
		{
			Name = "brownkitcheneast";
		}

		public brownkitcheneastAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}