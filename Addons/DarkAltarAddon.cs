
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
	public class DarkAltarAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {6875, 0, -6, 0}, {6875, 2, -6, 0}, {6875, -1, -6, 0}// 2	7	9	
			, {6875, 1, -6, 0}, {6875, 1, 7, 0}, {6875, 2, 4, 0}// 13	15	16	
			, {6875, -1, 7, 0}, {6875, -1, 4, 0}, {6875, 3, 5, 0}// 18	19	26	
			, {6875, 3, 6, 0}, {6875, 2, 6, 0}, {6875, -1, -2, 0}// 29	32	33	
			, {6875, -1, -3, 0}, {6875, -1, 6, 0}, {6875, 3, -4, 0}// 37	47	50	
			, {6875, -1, -5, 0}, {6875, -2, 5, 0}, {6875, 0, 7, 0}// 58	62	77	
			, {6875, -2, -5, 0}, {6875, 2, -5, 0}, {6875, 3, -5, 0}// 78	80	86	
			, {6875, -2, 6, 0}, {6875, 2, 7, 0}, {6875, 2, 3, 0}// 90	98	109	
			, {6875, -2, -4, 0}, {6875, -1, 3, 0}, {6875, 2, -2, 0}// 114	119	123	
			, {6875, 2, -3, 0}// 126	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DarkAltarAddonDeed();
			}
		}

		[ Constructable ]
		public DarkAltarAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1875, 0, -7, 0, 1908, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1885, -2, -6, 0, 1908, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1875, 2, -7, 0, 1908, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1884, 3, -7, 0, 1908, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1881, -2, -7, 0, 1908, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1875, -1, -7, 0, 1908, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1887, 3, -6, 0, 1908, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1875, 1, -7, 0, 1908, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1881, -3, -6, 0, 1908, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1884, 4, -6, 0, 1908, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1872, 1, 4, 0, 1908, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1886, 4, 6, 0, 1908, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 1872, 1, 3, 0, 1908, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1872, 0, -2, 0, 1908, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 4846, 2, 1, 1, 0, 0, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1883, -3, 7, 0, 1908, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1888, -2, 1, 0, 1908, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1872, 4, -4, 0, 1908, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1872, 4, 5, 0, 1908, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1872, -1, -4, 0, 1908, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1872, 0, -5, 0, 1908, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1872, 1, 5, 0, 1908, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1872, 1, -1, 0, 1908, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 1872, 1, -2, 0, 1908, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 1888, -2, 7, 0, 1908, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 1886, 3, -3, 0, 1908, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 4846, -1, 1, 1, 0, 0, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1886, 3, 7, 0, 1908, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1876, -2, 2, 0, 1908, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 379, 1, 1, 0, 1175, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 1872, 2, -4, 0, 1908, -1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 1888, -3, 6, 0, 1908, -1, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 1872, 2, 5, 0, 1908, -1, "", 1);// 46
			AddComplexComponent( (BaseAddon) this, 1873, 2, 8, 0, 1908, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 4846, -1, 0, 1, 0, 0, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1872, 0, -1, 0, 1908, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1887, 3, 4, 0, 1908, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1881, -4, 4, 0, 1908, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 1875, 4, 4, 0, 1908, -1, "", 1);// 54
			AddComplexComponent( (BaseAddon) this, 8707, 4, 1, 13, 2747, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 1884, 4, 0, 0, 1908, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1885, -2, 4, 0, 1908, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1882, 4, 7, 0, 1908, -1, "", 1);// 59
			AddComplexComponent( (BaseAddon) this, 1882, 3, 8, 0, 1908, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 6571, -3, -4, 11, 0, 1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 1872, 2, 2, 0, 1908, -1, "", 1);// 63
			AddComplexComponent( (BaseAddon) this, 1872, 0, 5, 0, 1908, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1872, -3, -4, 0, 1908, -1, "", 1);// 65
			AddComplexComponent( (BaseAddon) this, 1872, 0, 4, 0, 1908, -1, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 1872, -1, 5, 0, 1908, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 4846, 2, 0, 1, 0, 0, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 7884, -3, -4, 5, 1175, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 1872, 1, -3, 0, 1908, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1885, -2, 0, 0, 1908, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1881, -4, -5, 0, 1908, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 7884, -3, 5, 5, 1175, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1882, 4, 1, 0, 1908, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1872, -1, -1, 0, 1908, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1874, 3, 3, 0, 1908, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 1873, 0, 8, 0, 1908, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1872, 0, 3, 0, 1908, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1883, -2, 8, 0, 1908, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1876, -4, 5, 0, 1908, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 1887, 4, -5, 0, 1908, -1, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1876, -4, -4, 0, 1908, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 1883, -4, -3, 0, 1908, -1, "", 1);// 87
			AddComplexComponent( (BaseAddon) this, 1881, -3, 0, 0, 1908, -1, "", 1);// 88
			AddComplexComponent( (BaseAddon) this, 1876, -2, -2, 0, 1908, -1, "", 1);// 89
			AddComplexComponent( (BaseAddon) this, 1872, 0, -4, 0, 1908, -1, "", 1);// 91
			AddComplexComponent( (BaseAddon) this, 6571, -3, 5, 11, 0, 1, "", 1);// 92
			AddComplexComponent( (BaseAddon) this, 6571, 4, 5, 11, 0, 1, "", 1);// 93
			AddComplexComponent( (BaseAddon) this, 1872, 0, 2, 0, 1908, -1, "", 1);// 94
			AddComplexComponent( (BaseAddon) this, 1883, -4, 6, 0, 1908, -1, "", 1);// 95
			AddComplexComponent( (BaseAddon) this, 1873, -3, -3, 0, 1908, -1, "", 1);// 96
			AddComplexComponent( (BaseAddon) this, 7884, 4, -4, 5, 1175, -1, "", 1);// 97
			AddComplexComponent( (BaseAddon) this, 1887, 3, 0, 0, 1908, -1, "", 1);// 99
			AddComplexComponent( (BaseAddon) this, 1872, 1, 2, 0, 1908, -1, "", 1);// 100
			AddComplexComponent( (BaseAddon) this, 1872, -1, 2, 0, 1908, -1, "", 1);// 101
			AddComplexComponent( (BaseAddon) this, 1873, -1, 8, 0, 1908, -1, "", 1);// 102
			AddComplexComponent( (BaseAddon) this, 1872, 1, -5, 0, 1908, -1, "", 1);// 103
			AddComplexComponent( (BaseAddon) this, 380, 0, 1, 0, 1175, -1, "", 1);// 104
			AddComplexComponent( (BaseAddon) this, 6571, 4, -4, 11, 0, 1, "", 1);// 105
			AddComplexComponent( (BaseAddon) this, 1872, -3, 5, 0, 1908, -1, "", 1);// 106
			AddComplexComponent( (BaseAddon) this, 1872, 0, 6, 0, 1908, -1, "", 1);// 107
			AddComplexComponent( (BaseAddon) this, 1874, 3, 2, 0, 1908, -1, "", 1);// 108
			AddComplexComponent( (BaseAddon) this, 1874, 3, -1, 0, 1908, -1, "", 1);// 110
			AddComplexComponent( (BaseAddon) this, 1885, -3, -5, 0, 1908, -1, "", 1);// 111
			AddComplexComponent( (BaseAddon) this, 7884, 4, 5, 5, 1175, -1, "", 1);// 112
			AddComplexComponent( (BaseAddon) this, 1872, 0, -3, 0, 1908, -1, "", 1);// 113
			AddComplexComponent( (BaseAddon) this, 1874, 3, -2, 0, 1908, -1, "", 1);// 115
			AddComplexComponent( (BaseAddon) this, 1872, 2, -1, 0, 1908, -1, "", 1);// 116
			AddComplexComponent( (BaseAddon) this, 1883, -3, 1, 0, 1908, -1, "", 1);// 117
			AddComplexComponent( (BaseAddon) this, 1873, 4, -3, 0, 1908, -1, "", 1);// 118
			AddComplexComponent( (BaseAddon) this, 1876, -2, -1, 0, 1908, -1, "", 1);// 120
			AddComplexComponent( (BaseAddon) this, 1888, -2, -3, 0, 1908, -1, "", 1);// 121
			AddComplexComponent( (BaseAddon) this, 8707, -2, 1, 13, 2747, -1, "", 1);// 122
			AddComplexComponent( (BaseAddon) this, 1876, -2, 3, 0, 1908, -1, "", 1);// 124
			AddComplexComponent( (BaseAddon) this, 1875, -3, 4, 0, 1908, -1, "", 1);// 125
			AddComplexComponent( (BaseAddon) this, 1872, 1, 6, 0, 1908, -1, "", 1);// 127
			AddComplexComponent( (BaseAddon) this, 381, 1, 0, 0, 1175, -1, "", 1);// 128
			AddComplexComponent( (BaseAddon) this, 1872, 1, -4, 0, 1908, -1, "", 1);// 129
			AddComplexComponent( (BaseAddon) this, 1886, 3, 1, 0, 1908, -1, "", 1);// 130
			AddComplexComponent( (BaseAddon) this, 1873, 1, 8, 0, 1908, -1, "", 1);// 131
			AddComplexComponent( (BaseAddon) this, 1884, 5, 4, 0, 1908, -1, "", 1);// 132
			AddComplexComponent( (BaseAddon) this, 1884, 5, -5, 0, 1908, -1, "", 1);// 133
			AddComplexComponent( (BaseAddon) this, 1882, 5, 6, 0, 1908, -1, "", 1);// 134
			AddComplexComponent( (BaseAddon) this, 1874, 5, -4, 0, 1908, -1, "", 1);// 135
			AddComplexComponent( (BaseAddon) this, 1874, 5, 5, 0, 1908, -1, "", 1);// 136
			AddComplexComponent( (BaseAddon) this, 1882, 5, -3, 0, 1908, -1, "", 1);// 137

		}

		public DarkAltarAddon( Serial serial ) : base( serial )
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

	public class DarkAltarAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DarkAltarAddon();
			}
		}

		[Constructable]
		public DarkAltarAddonDeed()
		{
			Name = "DarkAltar";
		}

		public DarkAltarAddonDeed( Serial serial ) : base( serial )
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
