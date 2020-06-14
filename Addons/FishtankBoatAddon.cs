//Created By Milva
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
	public class FishtankBoatAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3332, 1, 3, 6}, {3378, 1, -1, 5}, {3270, 1, 2, 8}// 3	5	7	
			, {15112, 0, 0, 16}, {15110, 0, 3, 7}, {15111, 0, 2, 13}// 9	10	30	
			, {4036, 1, 1, 10}, {4950, 0, 1, 7}, {4949, 0, 2, 7}// 33	37	39	
			, {15105, 1, 2, 8}, {4039, 0, 3, 11}, {4962, 0, 0, 4}// 41	47	50	
			, {15114, 1, 0, 8}, {15120, 0, 1, 14}, {15118, 1, 0, 17}// 60	66	68	
			, {3332, 1, 0, 6}, {8949, 1, 1, 7}, {5367, 2, -3, 10}// 86	93	95	
			, {9315, 0, -1, 5}, {15101, 1, 1, 9}, {9315, 0, 1, 5}// 99	101	102	
			, {9315, 0, 2, 5}, {9315, 0, 3, 5}, {9315, 1, -1, 5}// 103	104	105	
			, {9315, 1, 0, 5}, {9315, 1, 1, 5}, {9315, 1, 2, 5}// 108	111	114	
			, {9315, 1, 3, 5}, {9315, 0, 0, 5}, {15106, 1, 0, 12}// 115	121	122	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FishtankBoatAddonDeed();
			}
		}

		[ Constructable ]
		public FishtankBoatAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 14, 1, -2, 0, 95, 1, "Fish Tank", 1);// 1
			AddComplexComponent( (BaseAddon) this, 4846, -1, 2, 11, 95, 0, "Water", 1);// 2
			AddComplexComponent( (BaseAddon) this, 4846, -1, 3, 11, 95, 1, "Water", 1);// 4
			AddComplexComponent( (BaseAddon) this, 16054, -1, 4, 1, 95, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 4846, -1, 3, 5, 95, 1, "Water", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4846, -1, 2, 5, 95, 0, "Water", 1);// 11
			AddComplexComponent( (BaseAddon) this, 4846, -1, 1, 5, 95, 0, "Water", 1);// 12
			AddComplexComponent( (BaseAddon) this, 4846, -1, 0, 5, 95, 0, "Water", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4846, -1, 0, 14, 95, 0, "Water", 1);// 14
			AddComplexComponent( (BaseAddon) this, 4846, -1, 0, 8, 95, 0, "Water", 1);// 15
			AddComplexComponent( (BaseAddon) this, 4846, -1, 2, 8, 95, 0, "Water", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1996, -1, -3, 15, 95, -1, "Fish Tank", 1);// 17
			AddComplexComponent( (BaseAddon) this, 4846, -1, -1, 5, 95, 1, "Water", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4846, -1, 2, 14, 95, 0, "Water", 1);// 19
			AddComplexComponent( (BaseAddon) this, 4846, -1, 3, 8, 95, 1, "Water", 1);// 20
			AddComplexComponent( (BaseAddon) this, 15, -2, -2, 0, 95, 1, "Fish Tank", 1);// 21
			AddComplexComponent( (BaseAddon) this, 22, -1, -2, 0, 95, -1, "Fish Tank", 1);// 22
			AddComplexComponent( (BaseAddon) this, 15, 1, -2, 0, 95, 1, "Fish Tank", 1);// 23
			AddComplexComponent( (BaseAddon) this, 16064, 0, 4, 1, 95, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1173, -1, -3, 0, 1260, -1, "Fish Tank", 1);// 25
			AddComplexComponent( (BaseAddon) this, 21, 1, -3, 14, 95, -1, "Fish Tank", 1);// 26
			AddComplexComponent( (BaseAddon) this, 9353, -2, 3, 5, 95, -1, "Fish Tank", 1);// 27
			AddComplexComponent( (BaseAddon) this, 4846, -1, -1, 8, 95, 1, "Water", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2282, 0, -1, 5, 176, -1, "coral", 1);// 29
			AddComplexComponent( (BaseAddon) this, 20, 1, -2, 14, 95, -1, "Fish Tank", 1);// 31
			AddComplexComponent( (BaseAddon) this, 6816, 0, 3, 5, 0, -1, "water plant", 1);// 32
			AddComplexComponent( (BaseAddon) this, 22, -1, -2, 14, 95, -1, "Water", 1);// 34
			AddComplexComponent( (BaseAddon) this, 892, 0, -1, 8, 956, -1, "Fish Tank", 1);// 35
			AddComplexComponent( (BaseAddon) this, 892, 2, 4, 8, 956, -1, "Fish Tank", 1);// 36
			AddComplexComponent( (BaseAddon) this, 22, 0, -2, 14, 95, -1, "Water", 1);// 38
			AddComplexComponent( (BaseAddon) this, 4846, -1, 1, 14, 95, 0, "Water", 1);// 40
			AddComplexComponent( (BaseAddon) this, 892, 1, 4, 8, 956, -1, "Fish Tank", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2252, 1, 1, 5, 956, -1, "Fish Tank", 1);// 43
			AddComplexComponent( (BaseAddon) this, 22, -1, 3, 0, 95, -1, "Water", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1173, 1, -2, 1, 1260, -1, "Fish Tank", 1);// 45
			AddComplexComponent( (BaseAddon) this, 6815, 0, 2, 4, 0, -1, "water plant", 1);// 46
			AddComplexComponent( (BaseAddon) this, 892, 1, -1, 8, 956, -1, "Fish Tank", 1);// 48
			AddComplexComponent( (BaseAddon) this, 892, 0, 4, 8, 956, -1, "Fish Tank", 1);// 49
			AddComplexComponent( (BaseAddon) this, 893, -1, 4, 8, 956, -1, "Fish Tank", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2252, 1, 2, 5, 956, -1, "Fish Tank", 1);// 52
			AddComplexComponent( (BaseAddon) this, 893, -1, 3, 8, 956, -1, "Fish Tank", 1);// 53
			AddComplexComponent( (BaseAddon) this, 892, 2, -1, 8, 956, -1, "Fish Tank", 1);// 54
			AddComplexComponent( (BaseAddon) this, 893, -1, 2, 8, 956, -1, "Fish Tank", 1);// 55
			AddComplexComponent( (BaseAddon) this, 893, -1, 1, 8, 956, -1, "Fish Tank", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1996, -1, -2, 15, 95, -1, "Fish Tank", 1);// 57
			AddComplexComponent( (BaseAddon) this, 893, -1, 0, 8, 956, -1, "Fish Tank", 1);// 58
			AddComplexComponent( (BaseAddon) this, 893, 2, 4, 8, 956, -1, "Fish Tank", 1);// 59
			AddComplexComponent( (BaseAddon) this, 6815, 1, 2, 5, 0, -1, "water plant", 1);// 61
			AddComplexComponent( (BaseAddon) this, 893, 2, 3, 8, 956, -1, "Fish Tank", 1);// 62
			AddComplexComponent( (BaseAddon) this, 14186, 0, 3, 0, 96, -1, "water", 1);// 63
			AddComplexComponent( (BaseAddon) this, 2254, 0, 3, 5, 956, -1, "Fish Tank", 1);// 64
			AddComplexComponent( (BaseAddon) this, 6814, 1, 0, 5, 0, -1, "water plant", 1);// 65
			AddComplexComponent( (BaseAddon) this, 893, 2, 0, 8, 956, -1, "Fish Tank", 1);// 67
			AddComplexComponent( (BaseAddon) this, 893, 2, 1, 8, 956, -1, "Fish Tank", 1);// 69
			AddComplexComponent( (BaseAddon) this, 5357, 0, 4, 7, 0, -1, "Map For Sunken Treasure", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2254, -1, 3, 5, 956, -1, "Fish Tank", 1);// 71
			AddComplexComponent( (BaseAddon) this, 14, -1, -4, 0, 95, 1, "Fish Tank", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1173, -1, -2, 1, 1260, -1, "Fish Tank", 1);// 73
			AddComplexComponent( (BaseAddon) this, 2253, 1, 3, 5, 956, -1, "Fish Tank", 1);// 74
			AddComplexComponent( (BaseAddon) this, 14186, 0, 1, 0, 96, -1, "water", 1);// 75
			AddComplexComponent( (BaseAddon) this, 15099, 0, 3, 6, 91, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 893, 2, 2, 8, 956, -1, "Fish Tank", 1);// 77
			AddComplexComponent( (BaseAddon) this, 2252, 1, -1, 5, 956, -1, "Fish Tank", 1);// 78
			AddComplexComponent( (BaseAddon) this, 15122, 1, -1, 9, 1166, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1996, 1, -2, 15, 95, -1, "Fish Tank", 1);// 80
			AddComplexComponent( (BaseAddon) this, 14, 0, -2, 0, 95, 1, "Fish Tank", 1);// 81
			AddComplexComponent( (BaseAddon) this, 15, 1, -3, 0, 95, 1, "Fish Tank", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1996, 0, -3, 15, 95, -1, "Fish Tank", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1173, 0, -3, 0, 1260, -1, "Fish Tank", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1996, 0, -2, 15, 95, -1, "Fish Tank", 1);// 85
			AddComplexComponent( (BaseAddon) this, 16053, 1, 4, 1, 95, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 16083, 2, 0, 1, 95, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 1173, 1, -3, 1, 1260, -1, "Fish Tank", 1);// 89
			AddComplexComponent( (BaseAddon) this, 9353, -2, -2, 5, 95, -1, "Fish Tank", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1173, 0, -2, 1, 1260, -1, "Fish Tank", 1);// 91
			AddComplexComponent( (BaseAddon) this, 14, -1, -2, 0, 95, 1, "Fish Tank", 1);// 92
			AddComplexComponent( (BaseAddon) this, 1996, 1, -3, 15, 95, -1, "Fish Tank", 1);// 94
			AddComplexComponent( (BaseAddon) this, 20, 1, 3, 0, 95, -1, "Fish Tank", 1);// 96
			AddComplexComponent( (BaseAddon) this, 12, 1, -4, 0, 95, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 9, -2, -4, 0, 95, -1, "Fish Tank", 1);// 98
			AddComplexComponent( (BaseAddon) this, 4846, -1, 1, 8, 95, 0, "Water", 1);// 100
			AddComplexComponent( (BaseAddon) this, 4846, -1, 3, 15, 96, 0, "Water", 1);// 106
			AddComplexComponent( (BaseAddon) this, 4846, -1, 2, 15, 96, 0, "Water", 1);// 107
			AddComplexComponent( (BaseAddon) this, 4846, -1, 1, 15, 96, 0, "Water", 1);// 109
			AddComplexComponent( (BaseAddon) this, 4846, -1, 0, 15, 96, 0, "Water", 1);// 110
			AddComplexComponent( (BaseAddon) this, 4846, -1, -1, 15, 96, 0, "Water", 1);// 112
			AddComplexComponent( (BaseAddon) this, 4846, -1, -1, 11, 95, 1, "Water", 1);// 113
			AddComplexComponent( (BaseAddon) this, 9353, 1, 3, 5, 95, -1, "Fish Tank", 1);// 116
			AddComplexComponent( (BaseAddon) this, 15, -2, -3, 0, 95, 1, "Fish Tank", 1);// 117
			AddComplexComponent( (BaseAddon) this, 22, 0, 3, 0, 95, -1, "Fish Tank", 1);// 118
			AddComplexComponent( (BaseAddon) this, 4846, -1, -1, 14, 96, 1, "", 1);// 119
			AddComplexComponent( (BaseAddon) this, 4846, -1, 3, 14, 96, 1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 21, -1, 3, 0, 95, -1, "Water", 1);// 123
			AddComplexComponent( (BaseAddon) this, 21, -1, 2, 0, 95, -1, "Water", 1);// 124
			AddComplexComponent( (BaseAddon) this, 22, 1, -2, 0, 95, -1, "Fish Tank", 1);// 125
			AddComplexComponent( (BaseAddon) this, 21, 1, 2, 0, 95, -1, "Fish Tank", 1);// 126
			AddComplexComponent( (BaseAddon) this, 21, 1, 1, 0, 95, -1, "Fish Tank", 1);// 127
			AddComplexComponent( (BaseAddon) this, 21, -1, 1, 0, 95, -1, "Water", 1);// 128
			AddComplexComponent( (BaseAddon) this, 22, 0, -2, 0, 95, -1, "Fish Tank", 1);// 129
			AddComplexComponent( (BaseAddon) this, 21, 1, -1, 0, 95, -1, "Fish Tank", 1);// 130
			AddComplexComponent( (BaseAddon) this, 21, -1, 0, 0, 95, -1, "Water", 1);// 131
			AddComplexComponent( (BaseAddon) this, 21, 1, 0, 0, 95, -1, "Fish Tank", 1);// 132
			AddComplexComponent( (BaseAddon) this, 21, -1, -1, 0, 95, -1, "Water", 1);// 133
			AddComplexComponent( (BaseAddon) this, 4846, -1, 0, 11, 95, 0, "Water", 1);// 134
			AddComplexComponent( (BaseAddon) this, 4846, -1, 1, 11, 95, 0, "Water", 1);// 135
			AddComplexComponent( (BaseAddon) this, 14, 0, -4, 0, 95, 1, "Fish Tank", 1);// 136
			AddComplexComponent( (BaseAddon) this, 16052, 0, 5, 1, 95, -1, "", 1);// 137

		}

		public FishtankBoatAddon( Serial serial ) : base( serial )
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

	public class FishtankBoatAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FishtankBoatAddon();
			}
		}

		[Constructable]
		public FishtankBoatAddonDeed()
		{
			Name = "FishtankBoat";
		}

		public FishtankBoatAddonDeed( Serial serial ) : base( serial )
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