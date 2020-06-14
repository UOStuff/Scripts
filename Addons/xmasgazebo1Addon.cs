
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
	public class xmasgazebo1Addon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10519, -1, 4, 27}, {10523, -1, -1, 27}, {10513, -1, 0, 27}// 29	30	31	
			, {10513, -1, 1, 27}, {10513, -1, 2, 27}, {10513, -1, 3, 27}// 32	33	34	
			, {9009, -3, 4, 2}, {10517, 4, 4, 27}, {10521, 4, -1, 27}// 35	84	85	
			, {10522, 0, 0, 30}, {10522, 1, 1, 33}, {10520, 3, 0, 30}// 86	87	88	
			, {10520, 2, 1, 33}, {10518, 0, 3, 30}, {10518, 1, 2, 33}// 89	90	91	
			, {10516, 3, 3, 30}, {10516, 2, 2, 33}, {10509, 1, 4, 27}// 92	93	94	
			, {10509, 2, 4, 27}, {10509, 3, 4, 27}, {10509, 0, 4, 27}// 95	96	97	
			, {10511, 4, 0, 27}, {10511, 4, 1, 27}, {10511, 4, 2, 27}// 98	99	100	
			, {10511, 4, 3, 27}, {10515, 0, -1, 27}, {10515, 1, -1, 27}// 101	102	103	
			, {10515, 2, -1, 27}, {10515, 3, -1, 27}, {10514, 1, 0, 30}// 104	105	106	
			, {10514, 2, 0, 30}, {10512, 0, 1, 30}, {10512, 0, 2, 30}// 107	108	109	
			, {10510, 3, 1, 30}, {10510, 3, 2, 30}, {10508, 1, 3, 30}// 110	111	112	
			, {10508, 2, 3, 30}, {9009, 4, 4, 2}, {9009, 4, -3, 2}// 113	115	116	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new xmasgazebo1AddonDeed();
			}
		}

		[ Constructable ]
		public xmasgazebo1Addon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1848, -2, -2, 0, 2006, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1848, -2, -1, 0, 2006, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1848, -2, 0, 0, 2006, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1848, -2, 1, 0, 2006, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1848, -2, 2, 0, 2006, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1848, -2, 3, 0, 2006, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1848, -1, -2, 0, 2006, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1848, -1, -1, 0, 2006, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1848, -1, 0, 0, 2006, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1848, -1, 1, 0, 2006, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1848, -1, 2, 0, 2006, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1848, -1, 3, 0, 2006, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1851, -2, -3, 0, 39, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1851, -1, -3, 0, 39, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1852, -3, -2, 0, 39, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1852, -3, -1, 0, 39, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1852, -3, 0, 0, 39, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1852, -3, 1, 0, 39, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1852, -3, 2, 0, 39, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1852, -3, 3, 0, 39, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1849, -1, 4, 0, 39, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1849, -2, 4, 0, 39, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1853, -3, -3, 0, 39, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1856, -3, 4, 0, 39, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 580, -2, -2, 5, 2006, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 580, -2, 3, 5, 2006, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2860, -2, 0, 5, 1153, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2860, -2, 1, 5, 1153, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1848, 0, -2, 0, 2006, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1848, 0, -1, 0, 2006, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1848, 0, 0, 0, 2006, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1848, 0, 1, 0, 2006, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1848, 0, 2, 0, 2006, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1848, 0, 3, 0, 2006, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1848, 1, -2, 0, 2006, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1848, 1, -1, 0, 2006, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1848, 1, 0, 0, 2006, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1848, 1, 1, 0, 2006, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1848, 1, 2, 0, 2006, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1848, 1, 3, 0, 2006, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1848, 2, -2, 0, 2006, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1848, 2, -1, 0, 2006, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1848, 2, 0, 0, 2006, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1848, 2, 1, 0, 2006, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1848, 2, 2, 0, 2006, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1848, 2, 3, 0, 2006, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1848, 3, -2, 0, 2006, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 1848, 3, -1, 0, 2006, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1848, 3, 0, 0, 2006, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1848, 3, 1, 0, 2006, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1848, 3, 2, 0, 2006, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1848, 3, 3, 0, 2006, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1850, 4, -2, 0, 39, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1850, 4, -1, 0, 39, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1850, 4, 0, 0, 39, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1850, 4, 1, 0, 39, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1850, 4, 2, 0, 39, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1850, 4, 3, 0, 39, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1851, 0, -3, 0, 39, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1851, 1, -3, 0, 39, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 1851, 2, -3, 0, 39, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1851, 3, -3, 0, 39, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1849, 3, 4, 0, 39, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1849, 2, 4, 0, 39, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1849, 1, 4, 0, 39, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1849, 0, 4, 0, 39, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1854, 4, 4, 0, 39, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1855, 4, -3, 0, 39, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 580, 3, -2, 5, 2006, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 580, 3, 3, 5, 2006, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 2861, 1, -2, 5, 1153, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 2861, 0, -2, 5, 1153, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 2861, 1, 3, 5, 1153, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 2861, 0, 3, 5, 1153, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 2860, 3, 0, 5, 1153, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 2860, 3, 1, 5, 1153, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 10749, 1, 1, 10, 0, 1, "", 1);// 114

		}

		public xmasgazebo1Addon( Serial serial ) : base( serial )
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

	public class xmasgazebo1AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new xmasgazebo1Addon();
			}
		}

		[Constructable]
		public xmasgazebo1AddonDeed()
		{
			Name = "xmasgazebo1";
		}

		public xmasgazebo1AddonDeed( Serial serial ) : base( serial )
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