
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
	public class BlueDiningSetEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {2493, -1, 1, 7}, {2493, -1, -1, 7}, {2517, 1, 1, 7}// 106	107	108	
			, {2517, 1, -1, 7}, {18831, 0, 2, 6}, {2491, 0, -2, 6}// 109	110	111	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BlueDiningSetEastAddonDeed();
			}
		}

		[ Constructable ]
		public BlueDiningSetEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2749, -3, -3, 0, 1176, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2749, -3, -2, 0, 1176, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2749, -3, -1, 0, 1176, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2749, -3, 0, 0, 1176, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2749, -3, 1, 0, 1176, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2749, -3, 2, 0, 1176, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2749, -3, 3, 0, 1176, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2749, -2, -3, 0, 1176, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2749, -2, -2, 0, 1176, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2749, -2, -1, 0, 1176, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2749, -2, 0, 0, 1176, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2749, -2, 1, 0, 1176, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2749, -2, 2, 0, 1176, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2749, -2, 3, 0, 1176, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2749, -1, -3, 0, 1176, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2749, -1, -2, 0, 1176, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2749, -1, -1, 0, 1176, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2749, -1, 0, 0, 1176, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2749, -1, 1, 0, 1176, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2749, -1, 2, 0, 1176, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2749, -1, 3, 0, 1176, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2749, 0, -3, 0, 1176, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2749, 0, -2, 0, 1176, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2749, 0, -1, 0, 1176, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2749, 0, 0, 0, 1176, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2749, 0, 1, 0, 1176, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2749, 0, 2, 0, 1176, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2749, 0, 3, 0, 1176, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2749, 1, -3, 0, 1176, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2749, 1, -2, 0, 1176, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2749, 1, -1, 0, 1176, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2749, 1, 0, 0, 1176, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2749, 1, 1, 0, 1176, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2749, 1, 2, 0, 1176, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2749, 1, 3, 0, 1176, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2749, 2, -3, 0, 1176, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2749, 2, -2, 0, 1176, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2749, 2, -1, 0, 1176, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2749, 2, 0, 0, 1176, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2749, 2, 1, 0, 1176, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2749, 2, 2, 0, 1176, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2749, 2, 3, 0, 1176, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2749, 3, -3, 0, 1176, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2749, 3, -2, 0, 1176, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2749, 3, -1, 0, 1176, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2749, 3, 0, 0, 1176, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2749, 3, 1, 0, 1176, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2749, 3, 2, 0, 1176, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2749, 3, 3, 0, 1176, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2754, 4, 4, 0, 2053, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 2755, -4, -4, 0, 2053, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2756, -4, 4, 0, 2053, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 2757, 4, -4, 0, 2053, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 2806, -4, -3, 0, 2053, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2806, -4, -2, 0, 2053, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 2806, -4, -1, 0, 2053, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 2806, -4, 0, 0, 2053, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 2806, -4, 1, 0, 2053, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 2806, -4, 2, 0, 2053, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 2806, -4, 3, 0, 2053, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 2807, -3, -4, 0, 2053, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 2807, -2, -4, 0, 2053, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 2807, -1, -4, 0, 2053, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 2807, 0, -4, 0, 2053, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 2807, 1, -4, 0, 2053, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 2807, 2, -4, 0, 2053, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 2807, 3, -4, 0, 2053, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2808, 4, -3, 0, 2053, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 2808, 4, -2, 0, 2053, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 2808, 4, -1, 0, 2053, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2808, 4, 0, 0, 2053, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2808, 4, 1, 0, 2053, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 2808, 4, 2, 0, 2053, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2808, 4, 3, 0, 2053, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 2809, -3, 4, 0, 2053, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 2809, -2, 4, 0, 2053, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 2809, -1, 4, 0, 2053, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 2809, 0, 4, 0, 2053, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 2809, 1, 4, 0, 2053, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 2809, 2, 4, 0, 2053, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 2809, 3, 4, 0, 2053, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 7617, -1, 2, 0, 2053, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 7619, -1, 0, 0, 2053, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 7617, 1, 2, 0, 2053, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 7619, 1, 0, 0, 2053, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 7618, 0, -2, 0, 2053, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 7618, 1, -2, 0, 2053, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 7618, -1, -2, 0, 2053, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 7619, -1, 1, 0, 2053, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 4633, -2, -1, 0, 2053, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 4633, -2, 1, 0, 2053, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 4635, 2, -1, 0, 2053, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 4635, 2, 1, 0, 2053, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 7619, 0, 0, 0, 2053, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 7619, 0, 1, 0, 2053, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 7617, 0, 2, 0, 2053, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 7619, 1, -1, 0, 2053, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 7619, 0, -1, 0, 2053, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 7619, -1, -1, 0, 2053, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 19678, 0, 0, 5, 0, 0, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 2519, 1, -1, 6, 1176, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 2519, -1, 1, 6, 1176, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 2519, -1, -1, 6, 1176, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 7619, 1, 1, 0, 2053, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 2519, 1, 1, 6, 1176, -1, "", 1);// 105

		}

		public BlueDiningSetEastAddon( Serial serial ) : base( serial )
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

	public class BlueDiningSetEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BlueDiningSetEastAddon();
			}
		}

		[Constructable]
		public BlueDiningSetEastAddonDeed()
		{
			Name = "BlueDiningSetEast";
		}

		public BlueDiningSetEastAddonDeed( Serial serial ) : base( serial )
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