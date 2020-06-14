
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class santasleigh1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2252, 2, -4, 1}, {2252, -1, -3, 1}, {2252, -1, -2, 1}// 10	11	12	
			, {2252, -1, -4, 1}, {2252, 2, -3, 1}, {2252, 2, -2, 1}// 13	14	15	
			, {2252, -1, -5, 1}, {2252, 2, -5, 1}, {2252, 2, -6, 1}// 16	17	18	
			, {2252, -1, -6, 1}, {2251, -1, -2, 2}, {2251, 2, -2, 2}// 19	20	21	
			, {2251, -1, -2, 3}, {2251, 2, -2, 3}, {10000, 1, 0, 3}// 22	23	39	
			, {10000, 1, 2, 3}, {10000, 1, 4, 3}, {10000, 1, 6, 4}// 40	41	42	
			, {10001, 2, 6, 7}, {10001, 0, 6, 6}, {10001, 2, 5, 7}// 43	44	45	
			, {10001, 2, 4, 7}, {10001, 2, 3, 7}, {10001, 2, 2, 7}// 46	47	48	
			, {10001, 2, 1, 7}, {10001, 0, 1, 6}, {10001, 0, 2, 6}// 49	50	51	
			, {10001, 0, 3, 6}, {10001, 0, 4, 6}, {10001, 0, 5, 6}// 52	53	54	
			, {5363, 0, -4, 4}, {8756, 0, -5, 3}, {937, 2, -1, 10}// 71	72	73	
			, {937, 0, -1, 10}, {937, 2, 0, 10}, {937, 0, 0, 10}// 74	75	76	
			, {12694, 2, -2, 6}, {9009, 0, -3, 3}, {9007, 1, -3, 3}// 77	89	90	
			, {9006, 2, -3, 3}, {5369, 1, -5, 6}, {11756, 1, -4, 4}// 91	93	94	
			, {10000, 0, 6, 4}, {10000, 0, 4, 3}, {10000, 0, 2, 3}// 104	105	106	
			, {10000, 0, 0, 3}, {935, 0, 0, 6}, {937, 0, 6, 1}// 107	108	109	
			, {937, 1, -3, 11}, {937, 1, -2, 11}, {937, 1, -1, 11}// 110	111	112	
			, {937, 0, -1, 0}// 114	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new santasleigh1AddonDeed();
			}
		}

		[ Constructable ]
		public santasleigh1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 159, 1, -7, 3, 38, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 159, 2, -7, 3, 38, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 159, 0, -7, 3, 38, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 157, 2, -7, 3, 38, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 157, -1, -7, 3, 38, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 12694, 2, -7, 13, 53, -1, "Christmas Light", 1);// 6
			AddComplexComponent( (BaseAddon) this, 12694, -1, -7, 13, 53, -1, "Christmas Light", 1);// 7
			AddComplexComponent( (BaseAddon) this, 12694, 0, -7, 13, 3, -1, "Christmas Light", 1);// 8
			AddComplexComponent( (BaseAddon) this, 12694, 1, -7, 13, 567, -1, "Christmas Light", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1997, 0, -6, 2, 773, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1997, 0, -5, 2, 773, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1997, 0, -4, 2, 773, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1997, 0, -3, 2, 773, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1997, 0, -2, 2, 773, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1997, 1, -6, 2, 773, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1997, 1, -5, 2, 773, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1997, 1, -4, 2, 773, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1997, 1, -3, 2, 773, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1997, 1, -2, 2, 773, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1997, 2, -6, 2, 773, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1997, 2, -5, 2, 773, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1997, 2, -4, 2, 773, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1997, 2, -3, 2, 773, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1997, 2, -2, 2, 773, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 164, 2, -2, 3, 38, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 164, 1, -2, 3, 38, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 164, 0, -2, 3, 38, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 163, 2, -2, 2, 38, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 163, -1, -2, 3, 38, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 163, -1, -3, 3, 38, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 158, 2, -6, 3, 38, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 158, -1, -6, 3, 30, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 158, 2, -5, 3, 38, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 158, -1, -5, 3, 38, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 158, -1, -4, 3, 38, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 158, 2, -4, 3, 38, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 9002, 0, -6, 4, 810, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 9002, 0, -5, 3, 984, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 9002, 1, -6, 3, 679, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 9003, 1, -5, 3, 911, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 12694, 2, -2, 6, 53, -1, "Christmas Light", 1);// 78
			AddComplexComponent( (BaseAddon) this, 12694, -1, -2, 6, 3, -1, "Christmas Light", 1);// 79
			AddComplexComponent( (BaseAddon) this, 12694, -1, -4, 13, 3, -1, "Christmas Light", 1);// 80
			AddComplexComponent( (BaseAddon) this, 12694, -1, -5, 13, 567, -1, "Christmas Light", 1);// 81
			AddComplexComponent( (BaseAddon) this, 12694, -1, -6, 13, 47, -1, "Christmas Loght", 1);// 82
			AddComplexComponent( (BaseAddon) this, 12694, 2, -6, 13, 47, -1, "Christmas Light", 1);// 83
			AddComplexComponent( (BaseAddon) this, 12694, 2, -5, 13, 567, -1, "Christmas Light", 1);// 84
			AddComplexComponent( (BaseAddon) this, 12694, 2, -4, 13, 3, -1, "Christmas Light", 1);// 85
			AddComplexComponent( (BaseAddon) this, 12694, 1, -2, 6, 47, -1, "Christmas Light", 1);// 86
			AddComplexComponent( (BaseAddon) this, 12694, 0, -2, 6, 567, -1, "Christmas Light", 1);// 87
			AddComplexComponent( (BaseAddon) this, 12694, -1, -3, 6, 53, -1, "Christmas Light", 1);// 88
			AddComplexComponent( (BaseAddon) this, 10903, 1, -6, 6, 0, 1, "Holiday Pyramid", 1);// 92
			AddComplexComponent( (BaseAddon) this, 14943, 1, 8, 1, 0, -1, "Rudolph", 1);// 95
			AddComplexComponent( (BaseAddon) this, 14933, 2, 7, 1, 0, -1, "Comet", 1);// 96
			AddComplexComponent( (BaseAddon) this, 14959, 0, 7, 1, 0, -1, "Cupid", 1);// 97
			AddComplexComponent( (BaseAddon) this, 14933, 1, 6, 9, 0, -1, "Dasher", 1);// 98
			AddComplexComponent( (BaseAddon) this, 14959, 2, 5, 1, 0, -1, "Prancer", 1);// 99
			AddComplexComponent( (BaseAddon) this, 14933, 2, 3, 1, 0, -1, "Dasher", 1);// 100
			AddComplexComponent( (BaseAddon) this, 14933, 2, 1, 1, 0, -1, "Vixen", 1);// 101
			AddComplexComponent( (BaseAddon) this, 14933, 1, 4, 8, 0, -1, "Donner", 1);// 102
			AddComplexComponent( (BaseAddon) this, 14933, 1, 2, 8, 0, -1, "Blitzen", 1);// 103
			AddComplexComponent( (BaseAddon) this, 8449, 0, -6, 7, 1194, -1, "a Holiday pig statue", 1);// 113

		}

		public santasleigh1Addon( Serial serial ) : base( serial )
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

	public class santasleigh1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new santasleigh1Addon();
			}
		}

		[Constructable]
		public santasleigh1AddonDeed()
		{
			Name = "santasleigh1";
		}

		public santasleigh1AddonDeed( Serial serial ) : base( serial )
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