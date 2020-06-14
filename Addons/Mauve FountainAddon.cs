
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
	public class MauveFountainAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1303, -5, -4, 0}, {1303, -5, -3, 0}, {1301, 4, -5, 5}// 1	2	3	
			, {6014, 4, -4, 5}, {6014, 3, -4, 5}, {6014, 2, -4, 5}// 4	5	6	
			, {6014, -2, -4, 0}, {6014, -1, -4, 0}, {6014, 0, -4, 0}// 7	8	9	
			, {6014, 1, -4, 0}, {6014, 1, -4, 5}, {6014, 0, -4, 5}// 10	11	12	
			, {6014, -1, -4, 5}, {6014, -2, -4, 5}, {6014, -3, -4, 5}// 13	14	15	
			, {6014, -4, -4, 4}, {6014, -4, -3, 5}, {6014, -4, -2, 5}// 16	17	18	
			, {6014, -4, -1, 5}, {6014, -4, 0, 5}, {6014, -4, 1, 5}// 19	20	21	
			, {6014, -4, 2, 5}, {6014, -4, 3, 5}, {6014, -4, 4, 5}// 22	23	24	
			, {6014, 4, -4, 0}, {6014, 4, -3, 0}, {6014, 4, -2, 0}// 25	26	27	
			, {6014, 4, -1, 0}, {6014, 4, 0, 0}, {6014, 4, 1, 0}// 28	29	30	
			, {6014, 4, 2, 0}, {6014, 4, 3, 0}, {6014, 4, 4, 0}// 31	32	33	
			, {13422, -3, -3, 5}, {13422, -3, -2, 5}, {13422, -3, -1, 5}// 34	35	36	
			, {13422, -3, 0, 5}, {13422, -3, 1, 5}, {13422, -3, 2, 5}// 37	38	39	
			, {13422, -3, 3, 5}, {13422, -2, -3, 5}, {13422, -2, -2, 5}// 40	41	42	
			, {13422, -2, -1, 5}, {13422, -2, 0, 5}, {13422, -2, 1, 5}// 43	44	45	
			, {13422, -2, 2, 5}, {13422, -2, 3, 5}, {13422, -1, -3, 5}// 46	47	48	
			, {13422, -1, -2, 5}, {13422, -1, -1, 5}, {13422, -1, 0, 5}// 49	50	51	
			, {13422, -1, 1, 5}, {13422, -1, 2, 5}, {13422, -1, 3, 5}// 52	53	54	
			, {13422, 0, -3, 5}, {13422, 0, -2, 5}, {13422, 0, -1, 5}// 55	56	57	
			, {13422, 0, 0, 5}, {13422, 0, 1, 5}, {13422, 0, 2, 5}// 58	59	60	
			, {13422, 0, 3, 5}, {13422, 1, -3, 5}, {13422, 1, -2, 5}// 61	62	63	
			, {13422, 1, -1, 5}, {13422, 1, 0, 5}, {13422, 1, 1, 5}// 64	65	66	
			, {13422, 1, 2, 5}, {13422, 1, 3, 5}, {13422, 2, -3, 5}// 67	68	69	
			, {13422, 2, -2, 5}, {13422, 2, -1, 5}, {13422, 2, 0, 5}// 70	71	72	
			, {13422, 2, 1, 5}, {13422, 2, 2, 5}, {13422, 2, 3, 5}// 73	74	75	
			, {13422, 3, -3, 5}, {13422, 3, -2, 5}, {13422, 3, -1, 5}// 76	77	78	
			, {13422, 3, 0, 5}, {13422, 3, 1, 5}, {13422, 3, 2, 5}// 79	80	81	
			, {13422, 3, 3, 5}, {6014, 4, -3, 5}, {6014, 4, -2, 5}// 82	104	105	
			, {6014, 4, -1, 5}, {6014, 4, 0, 5}, {6014, 4, 1, 5}// 106	107	108	
			, {6014, 4, 2, 5}, {6014, 4, 3, 5}, {6014, 4, 4, 5}// 109	110	111	
			, {6014, 3, 4, 5}, {6014, -3, 4, 5}, {6014, -2, 4, 5}// 113	114	115	
			, {6014, -1, 4, 5}, {6014, 0, 4, 5}, {6014, 1, 4, 5}// 116	117	118	
			, {6014, 2, 4, 5}, {13446, -1, -2, 6}, {13452, 2, 2, 6}// 119	139	140	
			, {13579, 1, 2, 17}, {13423, 1, 1, 22}, {14138, 2, 2, 58}// 141	142	148	
			, {6014, 4, 5, 6}, {6014, 3, 5, 5}, {6014, 2, 5, 5}// 154	155	156	
			, {6014, 1, 5, 5}, {6014, 0, 5, 5}, {6014, -1, 5, 5}// 157	158	159	
			, {6014, -2, 5, 5}, {6014, -3, 5, 5}, {6014, -4, 5, 6}// 160	161	162	
			, {6014, 4, 5, 0}, {1301, 5, -5, 0}, {1301, 5, -5, 5}// 163	164	165	
			, {6014, 5, -3, 5}, {6014, 5, -4, 5}, {6014, 5, -2, 5}// 166	167	168	
			, {6014, 5, -1, 5}, {6014, 5, 0, 5}, {6014, 5, 1, 5}// 169	170	171	
			, {6014, 5, 2, 5}, {6014, 5, 4, 5}, {6014, 5, 3, 5}// 172	173	174	
			, {6014, 5, 5, 6}// 175	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new MauveFountainAddonDeed();
			}
		}

		[ Constructable ]
		public MauveFountainAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 16678, -3, 3, 6, 1217, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 16678, -3, 2, 6, 1217, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 16678, -3, 1, 6, 1217, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 16678, -3, 0, 6, 1217, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 16678, -3, -1, 6, 1217, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 16678, -3, -2, 6, 1217, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 16678, -3, -3, 6, 1217, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 16678, -2, -3, 6, 1217, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 16678, -1, -3, 6, 1217, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 16678, -1, -3, 6, 1217, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 16678, 0, -3, 6, 1217, -1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 16678, 1, -3, 6, 1217, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 16678, 2, -3, 6, 1217, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 16678, 3, -3, 6, 1217, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 16678, 4, -2, 6, 1217, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 16678, 4, -1, 6, 1217, -1, "", 1);// 98
			AddComplexComponent( (BaseAddon) this, 16678, 4, 0, 6, 1217, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 16678, 4, 1, 6, 1217, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 16678, 4, 2, 6, 1217, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 16678, 4, 3, 6, 1217, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 16678, 4, 4, 6, 1217, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 16678, 4, -3, 6, 1217, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 16678, -2, 4, 6, 1217, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 16678, -1, 4, 6, 1217, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 16678, 0, 4, 6, 1217, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 16678, 1, 4, 6, 1217, -1, "", 1);// 123
			AddComplexComponent( (BaseAddon) this, 16678, 2, 4, 6, 1217, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 16678, 3, 4, 6, 1217, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 16678, -3, 4, 6, 1217, -1, "", 1);// 126
			AddComplexComponent( (BaseAddon) this, 16701, 1, 1, 7, 1217, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 16701, 0, 1, 7, 1217, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 16689, 1, 0, 7, 1217, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 16689, 0, 0, 7, 1217, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 16678, 2, 0, 7, 1217, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 16678, 2, 1, 7, 1217, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 16678, -1, 1, 7, 1217, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 16678, -1, 0, 7, 1217, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 3223, 2, 0, 12, 1367, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 3223, 2, 1, 12, 1367, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 3223, -1, 0, 12, 1367, -1, "", 1);// 137
			AddComplexComponent( (BaseAddon) this, 3223, -1, 1, 12, 1367, -1, "", 1);// 138
			AddComplexComponent( (BaseAddon) this, 16678, 1, 1, 23, 1217, -1, "", 1);// 143
			AddComplexComponent( (BaseAddon) this, 13920, 1, 1, 43, 1217, -1, "", 1);// 144
			AddComplexComponent( (BaseAddon) this, 16678, 1, 1, 28, 1217, -1, "", 1);// 145
			AddComplexComponent( (BaseAddon) this, 16678, 1, 1, 33, 1217, -1, "", 1);// 146
			AddComplexComponent( (BaseAddon) this, 16678, 1, 1, 38, 1217, -1, "", 1);// 147
			AddComplexComponent( (BaseAddon) this, 9036, 2, 1, 17, 1217, -1, "", 1);// 149
			AddComplexComponent( (BaseAddon) this, 9036, 2, 0, 17, 1217, -1, "", 1);// 150
			AddComplexComponent( (BaseAddon) this, 9036, -1, 1, 17, 1217, -1, "", 1);// 151
			AddComplexComponent( (BaseAddon) this, 9036, -1, 0, 17, 1217, -1, "", 1);// 152
			AddComplexComponent( (BaseAddon) this, 9036, 1, 1, 43, 1217, -1, "", 1);// 153

		}

		public MauveFountainAddon( Serial serial ) : base( serial )
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

	public class MauveFountainAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new MauveFountainAddon();
			}
		}

		[Constructable]
		public MauveFountainAddonDeed()
		{
			Name = "Mauve Fountain";
		}

		public MauveFountainAddonDeed( Serial serial ) : base( serial )
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