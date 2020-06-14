
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
	public class asianbedroomredgreyNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10327, 2, -2, 0}, {10327, -2, -2, 0}, {2898, -2, 2, 0}// 65	66	133	
			, {10314, 2, 3, 0}// 145	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new asianbedroomredgreyNSAddonDeed();
			}
		}

		[ Constructable ]
		public asianbedroomredgreyNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2795, -2, -2, 0, 2751, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2795, -2, -1, 0, 2751, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2795, -2, 0, 0, 2751, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2795, -2, 1, 0, 2751, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2795, -2, 2, 0, 2751, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2795, -2, 3, 0, 2751, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2795, -1, -2, 0, 2751, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2795, -1, -1, 0, 2751, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2795, -1, 0, 0, 2751, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2795, -1, 1, 0, 2751, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2795, -1, 2, 0, 2751, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2795, -1, 3, 0, 2751, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2795, 0, -2, 0, 2751, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2795, 0, -1, 0, 2751, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2795, 0, 0, 0, 2751, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2795, 0, 1, 0, 2751, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2795, 0, 2, 0, 2751, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2795, 0, 3, 0, 2751, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2795, 1, -2, 0, 2751, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2795, 1, -1, 0, 2751, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2795, 1, 0, 0, 2751, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2795, 1, 1, 0, 2751, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2795, 1, 2, 0, 2751, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2795, 1, 3, 0, 2751, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2795, 2, -2, 0, 2751, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2795, 2, -1, 0, 2751, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2795, 2, 0, 0, 2751, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2795, 2, 1, 0, 2751, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2795, 2, 2, 0, 2751, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2795, 2, 3, 0, 2751, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2787, 3, 4, 0, 2751, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2788, -3, -3, 0, 2751, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2789, -3, 4, 0, 2751, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2790, 3, -3, 0, 2751, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2791, -3, -2, 0, 2751, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2791, -3, -1, 0, 2751, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 2791, -3, 0, 0, 2751, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 2791, -3, 1, 0, 2751, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 2791, -3, 2, 0, 2751, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 2791, -3, 3, 0, 2751, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 2792, -2, -3, 0, 2751, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2792, -1, -3, 0, 2751, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2792, 0, -3, 0, 2751, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2792, 1, -3, 0, 2751, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2792, 2, -3, 0, 2751, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2793, 3, -2, 0, 2751, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2793, 3, -1, 0, 2751, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2793, 3, 0, 0, 2751, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2793, 3, 1, 0, 2751, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2793, 3, 2, 0, 2751, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 2793, 3, 3, 0, 2751, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2794, -2, 4, 0, 2751, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 2794, -1, 4, 0, 2751, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 2794, 0, 4, 0, 2751, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 2794, 1, 4, 0, 2751, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 2794, 2, 4, 0, 2751, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 10072, -2, -4, 0, 2450, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 10072, -1, -4, 0, 2450, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 10072, 0, -4, 0, 2450, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 10072, 1, -4, 0, 2450, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 10072, 2, -4, 0, 2450, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 10069, 2, -3, 0, 2450, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 10069, -2, -3, 0, 2450, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 10079, -3, -3, 1, 2450, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 5990, -1, -3, 0, 2747, -1, "(1,5990): -1, -1, 0", 1);// 67
			AddComplexComponent( (BaseAddon) this, 5990, -1, -2, 0, 2747, -1, "(2,5990): -1, 0, 0", 1);// 68
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 0, 2747, -1, "(3,5990): -1, 1, 0", 1);// 69
			AddComplexComponent( (BaseAddon) this, 5990, 0, -3, 0, 2747, -1, "(4,5990): 0, -1, 0", 1);// 70
			AddComplexComponent( (BaseAddon) this, 5990, 0, -2, 0, 2747, -1, "(5,5990): 0, 0, 0", 1);// 71
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 0, 2747, -1, "(6,5990): 0, 1, 0", 1);// 72
			AddComplexComponent( (BaseAddon) this, 5990, 1, -3, 0, 2747, -1, "(7,5990): 1, -1, 0", 1);// 73
			AddComplexComponent( (BaseAddon) this, 5990, 1, -2, 0, 2747, -1, "(8,5990): 1, 0, 0", 1);// 74
			AddComplexComponent( (BaseAddon) this, 5990, -1, -3, 1, 2747, -1, "(10,5990): -1, -1, 1", 1);// 75
			AddComplexComponent( (BaseAddon) this, 5990, -1, -2, 1, 2747, -1, "(11,5990): -1, 0, 1", 1);// 76
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 1, 2747, -1, "(12,5990): -1, 1, 1", 1);// 77
			AddComplexComponent( (BaseAddon) this, 5990, 0, -3, 1, 2747, -1, "(13,5990): 0, -1, 1", 1);// 78
			AddComplexComponent( (BaseAddon) this, 5990, 0, -2, 1, 2747, -1, "(14,5990): 0, 0, 1", 1);// 79
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 1, 2747, -1, "(15,5990): 0, 1, 1", 1);// 80
			AddComplexComponent( (BaseAddon) this, 5990, 1, -3, 1, 2747, -1, "(16,5990): 1, -1, 1", 1);// 81
			AddComplexComponent( (BaseAddon) this, 5990, 1, -2, 1, 2747, -1, "(17,5990): 1, 0, 1", 1);// 82
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 1, 2747, -1, "(18,5990): 1, 1, 1", 1);// 83
			AddComplexComponent( (BaseAddon) this, 5990, -1, -3, 2, 2747, -1, "(19,5990): -1, -1, 2", 1);// 84
			AddComplexComponent( (BaseAddon) this, 5990, -1, -2, 2, 2747, -1, "(20,5990): -1, 0, 2", 1);// 85
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 2, 2747, -1, "(21,5990): -1, 1, 2", 1);// 86
			AddComplexComponent( (BaseAddon) this, 5990, 0, -3, 2, 2747, -1, "(22,5990): 0, -1, 2", 1);// 87
			AddComplexComponent( (BaseAddon) this, 5990, 0, -2, 2, 2747, -1, "(23,5990): 0, 0, 2", 1);// 88
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 2, 2747, -1, "(24,5990): 0, 1, 2", 1);// 89
			AddComplexComponent( (BaseAddon) this, 5990, 1, -3, 2, 2747, -1, "(25,5990): 1, -1, 2", 1);// 90
			AddComplexComponent( (BaseAddon) this, 5990, 1, -2, 2, 2747, -1, "(26,5990): 1, 0, 2", 1);// 91
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 2, 2747, -1, "(27,5990): 1, 1, 2", 1);// 92
			AddComplexComponent( (BaseAddon) this, 5990, -1, -3, 3, 2747, -1, "(28,5990): -1, -1, 3", 1);// 93
			AddComplexComponent( (BaseAddon) this, 5990, -1, -2, 3, 2747, -1, "(29,5990): -1, 0, 3", 1);// 94
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 3, 2747, -1, "(30,5990): -1, 1, 3", 1);// 95
			AddComplexComponent( (BaseAddon) this, 5990, 0, -3, 3, 2747, -1, "(31,5990): 0, -1, 3", 1);// 96
			AddComplexComponent( (BaseAddon) this, 5990, 0, -2, 3, 2747, -1, "(32,5990): 0, 0, 3", 1);// 97
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 3, 2747, -1, "(33,5990): 0, 1, 3", 1);// 98
			AddComplexComponent( (BaseAddon) this, 5990, 1, -3, 3, 2747, -1, "(34,5990): 1, -1, 3", 1);// 99
			AddComplexComponent( (BaseAddon) this, 5990, 1, -2, 3, 2747, -1, "(35,5990): 1, 0, 3", 1);// 100
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 3, 2747, -1, "(36,5990): 1, 1, 3", 1);// 101
			AddComplexComponent( (BaseAddon) this, 5990, -1, -3, 4, 2747, -1, "(37,5990): -1, -1, 4", 1);// 102
			AddComplexComponent( (BaseAddon) this, 5990, -1, -2, 4, 2747, -1, "(38,5990): -1, 0, 4", 1);// 103
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 4, 2747, -1, "(39,5990): -1, 1, 4", 1);// 104
			AddComplexComponent( (BaseAddon) this, 5990, -1, -3, 4, 2747, -1, "(40,5990): -1, -1, 4", 1);// 105
			AddComplexComponent( (BaseAddon) this, 5990, 0, -2, 4, 2747, -1, "(41,5990): 0, 0, 4", 1);// 106
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 4, 2747, -1, "(42,5990): 0, 1, 4", 1);// 107
			AddComplexComponent( (BaseAddon) this, 5990, 1, -3, 4, 2747, -1, "(43,5990): 1, -1, 4", 1);// 108
			AddComplexComponent( (BaseAddon) this, 5990, 1, -2, 4, 2747, -1, "(44,5990): 1, 0, 4", 1);// 109
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 4, 2747, -1, "(45,5990): 1, 1, 4", 1);// 110
			AddComplexComponent( (BaseAddon) this, 5990, -1, -3, 5, 2747, -1, "(46,5990): -1, -1, 5", 1);// 111
			AddComplexComponent( (BaseAddon) this, 5990, -1, -2, 5, 2747, -1, "(47,5990): -1, 0, 5", 1);// 112
			AddComplexComponent( (BaseAddon) this, 5990, -1, -1, 5, 2747, -1, "(48,5990): -1, 1, 5", 1);// 113
			AddComplexComponent( (BaseAddon) this, 5990, 0, -3, 5, 2747, -1, "(49,5990): 0, -1, 5", 1);// 114
			AddComplexComponent( (BaseAddon) this, 5990, 0, -2, 5, 2747, -1, "(50,5990): 0, 0, 5", 1);// 115
			AddComplexComponent( (BaseAddon) this, 5990, 0, -1, 5, 2747, -1, "(51,5990): 0, 1, 5", 1);// 116
			AddComplexComponent( (BaseAddon) this, 5990, 1, -3, 5, 2747, -1, "(52,5990): 1, -1, 5", 1);// 117
			AddComplexComponent( (BaseAddon) this, 5990, 1, -2, 5, 2747, -1, "(53,5990): 1, 0, 5", 1);// 118
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 5, 2747, -1, "(54,5990): 1, 1, 5", 1);// 119
			AddComplexComponent( (BaseAddon) this, 3530, -1, -1, 6, 2747, -1, "(55,3530): -1, 1, 6", 1);// 120
			AddComplexComponent( (BaseAddon) this, 5029, -1, -3, 6, 2747, -1, "(56,5029): -1, -1, 6", 1);// 121
			AddComplexComponent( (BaseAddon) this, 5029, 1, -3, 6, 2747, -1, "(57,5029): 1, -1, 6", 1);// 122
			AddComplexComponent( (BaseAddon) this, 5690, 0, -3, 6, 2747, -1, "(58,5690): 0, -1, 6", 1);// 123
			AddComplexComponent( (BaseAddon) this, 3530, -1, -2, 6, 2747, -1, "(59,3530): -1, 0, 6", 1);// 124
			AddComplexComponent( (BaseAddon) this, 3530, 0, -2, 6, 2747, -1, "(60,3530): 0, 0, 6", 1);// 125
			AddComplexComponent( (BaseAddon) this, 3530, 0, -1, 6, 2747, -1, "(61,3530): 0, 1, 6", 1);// 126
			AddComplexComponent( (BaseAddon) this, 3530, 1, -2, 6, 2747, -1, "(62,3530): 1, 0, 6", 1);// 127
			AddComplexComponent( (BaseAddon) this, 3530, 1, -1, 6, 2747, -1, "(63,3530): 1, 1, 6", 1);// 128
			AddComplexComponent( (BaseAddon) this, 5990, 1, -1, 0, 2747, -1, "(9,5990): 1, 1, 0", 1);// 129
			AddComplexComponent( (BaseAddon) this, 4095, -2, -2, 7, 2660, -1, "Milk", 1);// 130
			AddComplexComponent( (BaseAddon) this, 2842, 2, -2, 9, 0, 2, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 10136, 2, -2, 14, 2517, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 10115, -2, 2, 3, 2747, -1, "Silk Robe", 1);// 134
			AddComplexComponent( (BaseAddon) this, 8967, -1, 1, 0, 2271, -1, "Slippers", 1);// 135
			AddComplexComponent( (BaseAddon) this, 7763, 1, 3, 0, 2660, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 7764, 1, 2, 0, 2660, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 7765, 1, 1, 0, 2660, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 7766, 0, 1, 0, 2660, -1, "", 1);// 139
			AddComplexComponent( (BaseAddon) this, 7767, 0, 2, 0, 2660, -1, "", 1);// 140
			AddComplexComponent( (BaseAddon) this, 7768, 0, 3, 0, 2660, -1, "", 1);// 141
			AddComplexComponent( (BaseAddon) this, 7770, -1, 2, 0, 2660, -1, "", 1);// 142
			AddComplexComponent( (BaseAddon) this, 7771, -1, 1, 0, 2660, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 7769, -1, 3, 0, 2660, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 7713, 1, -1, 7, 2774, -1, "A Knight's Tale", 1);// 146

		}

		public asianbedroomredgreyNSAddon( Serial serial ) : base( serial )
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

	public class asianbedroomredgreyNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new asianbedroomredgreyNSAddon();
			}
		}

		[Constructable]
		public asianbedroomredgreyNSAddonDeed()
		{
			Name = "asianbedroomredgreyNS";
		}

		public asianbedroomredgreyNSAddonDeed( Serial serial ) : base( serial )
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