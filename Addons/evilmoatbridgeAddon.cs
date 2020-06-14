
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
	public class evilmoatbridgeAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {13042, -3, -4, 0}, {1277, -3, -1, 5}, {1277, -3, -2, 5}// 1	10	17	
			, {1277, 2, -4, 5}, {1277, -3, 1, 5}, {7025, -3, 4, 10}// 20	22	24	
			, {1277, 2, -3, 5}, {1277, 2, 2, 5}, {1277, 2, 3, 5}// 25	32	41	
			, {1277, -3, -4, 5}, {8707, -3, 1, 17}, {1277, 2, -1, 5}// 48	49	51	
			, {1277, -3, 2, 5}, {8707, 2, 1, 17}, {1277, 2, 1, 5}// 52	56	61	
			, {1277, 2, 4, 5}, {1277, -3, 4, 5}, {1277, -3, 3, 5}// 67	78	79	
			, {1277, -3, -3, 5}, {1277, -3, 0, 5}, {1277, 2, 0, 5}// 83	85	87	
			, {13042, -3, 0, 0}, {1277, 2, -2, 5}, {7037, 3, -1, 3}// 88	89	93	
			, {7025, 2, 4, 10}, {7025, 2, 0, 10}, {8707, 2, -3, 17}// 98	100	101	
			, {8707, -3, -3, 17}, {7025, -3, 0, 10}// 102	103	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new evilmoatbridgeAddonDeed();
			}
		}

		[ Constructable ]
		public evilmoatbridgeAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1872, 2, -3, 5, 2747, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1277, -1, 2, 5, 1892, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1277, -2, 2, 5, 1892, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1277, 1, -2, 5, 1892, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1277, -2, -3, 5, 1892, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1872, -3, -3, 5, 2747, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1872, 2, -3, 10, 2747, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1872, 2, 3, 5, 2747, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1872, -3, 2, 5, 2747, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1823, -1, 5, 0, 2747, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1872, 2, 3, 10, 2747, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1277, -2, -2, 5, 1892, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1277, 1, 2, 5, 1892, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1277, 1, 1, 5, 1892, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1872, -3, -2, 5, 2747, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1823, -2, 5, 0, 2747, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 14089, 2, 0, 10, 0, 1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 14089, -3, 0, 10, 0, 1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1277, -1, 1, 5, 1892, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1277, 0, 2, 5, 1892, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1872, 2, -4, 5, 2747, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1872, 2, -1, 10, 2747, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1872, 2, -2, 5, 2747, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1872, -3, -1, 10, 2747, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1872, -3, 4, 5, 2747, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1872, -3, 1, 10, 2747, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1872, 2, 2, 5, 2747, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 14089, 2, 4, 10, 0, 1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1872, -3, 0, 5, 2747, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1277, 0, 1, 5, 1892, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 13042, 2, 4, 0, 2747, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1277, 0, 0, 5, 1892, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1823, 1, 5, 0, 2747, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1277, -1, -2, 5, 1892, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 13042, 2, -4, 0, 2747, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1872, 2, 1, 10, 2747, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1277, -2, -4, 5, 1892, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1277, 0, 3, 5, 1892, -1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1277, 0, 4, 5, 1892, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 13042, 2, 0, 0, 2747, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1823, 0, 5, 0, 2747, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 13042, -3, 4, 0, 2747, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 14089, -3, 4, 10, 0, 1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1277, 1, -4, 5, 1892, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1277, 1, 4, 5, 1892, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1872, 2, -1, 5, 2747, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1872, -3, 3, 10, 2747, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 1872, -3, 1, 5, 2747, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1872, -3, 3, 5, 2747, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1277, -1, 0, 5, 1892, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1277, -1, -3, 5, 1892, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1277, -1, -4, 5, 1892, -1, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1872, -3, -3, 10, 2747, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1277, 0, -3, 5, 1892, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1277, 1, -3, 5, 1892, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1277, 1, -1, 5, 1892, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1277, 1, 3, 5, 1892, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1872, 2, 4, 5, 2747, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1277, -2, 0, 5, 1892, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1277, -2, -1, 5, 1892, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 1277, -2, 3, 5, 1892, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 1277, -1, -1, 5, 1892, -1, "", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1277, -1, 4, 5, 1892, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1277, -1, 3, 5, 1892, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1277, -2, 4, 5, 1892, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1277, 0, -4, 5, 1892, -1, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 1277, 0, -1, 5, 1892, -1, "", 1);// 90
			AddComplexComponent( (BaseAddon) this, 1872, 2, 0, 5, 2747, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 1872, -3, -1, 5, 2747, -1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 1277, 1, 0, 5, 1892, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 1277, -2, 1, 5, 1892, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 1277, 0, -2, 5, 1892, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 1872, -3, -4, 5, 2747, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1872, 2, 1, 5, 2747, -1, "", 1);// 99

		}

		public evilmoatbridgeAddon( Serial serial ) : base( serial )
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

	public class evilmoatbridgeAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new evilmoatbridgeAddon();
			}
		}

		[Constructable]
		public evilmoatbridgeAddonDeed()
		{
			Name = "evilmoatbridge";
		}

		public evilmoatbridgeAddonDeed( Serial serial ) : base( serial )
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