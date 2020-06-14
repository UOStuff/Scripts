
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
	public class ElegantbdrNSAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {10651, 3, 3, 16}, {10645, 3, -2, 16}, {10645, 3, -1, 16}// 43	44	45	
			, {10645, 3, 0, 16}, {10645, 3, 1, 16}, {10645, 3, 2, 16}// 46	47	48	
			, {10645, -3, -2, 16}, {10645, -3, -1, 16}, {10645, -3, 0, 16}// 49	50	51	
			, {10645, -3, 1, 16}, {10645, -3, 2, 16}, {10645, -3, 3, 16}// 52	53	54	
			, {10648, -2, 3, 16}, {10648, -1, 3, 16}, {10648, 0, 3, 16}// 55	56	57	
			, {10648, 1, 3, 16}, {10648, 2, 3, 16}, {10648, -2, -3, 16}// 58	59	60	
			, {10648, -1, -3, 16}, {10648, 0, -3, 16}, {10648, 1, -3, 16}// 61	62	63	
			, {10648, 2, -3, 16}, {10648, 3, -3, 16}, {10642, -3, -3, 16}// 64	65	66	
			, {4555, -1, -2, 8}// 68	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ElegantbdrNSAddonDeed();
			}
		}

		[ Constructable ]
		public ElegantbdrNSAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2769, -1, -1, 0, 2321, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 2769, -1, 0, 0, 2321, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 2769, -1, 1, 0, 2321, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 2769, -1, 2, 0, 2321, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 2769, 0, -1, 0, 2321, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 2769, 0, 0, 0, 2321, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 2769, 0, 1, 0, 2321, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 2769, 0, 2, 0, 2321, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 2769, 1, -1, 0, 2321, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 2769, 1, 0, 0, 2321, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 2769, 1, 1, 0, 2321, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 2769, 1, 2, 0, 2321, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 2769, 2, -1, 0, 2321, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 2769, 2, 0, 0, 2321, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 2769, 2, 1, 0, 2321, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 2769, 2, 2, 0, 2321, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 2770, 3, 3, 0, 2321, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 2771, -2, -2, 0, 2321, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 2772, -2, 3, 0, 2321, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 2773, 3, -2, 0, 2321, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 2774, -2, -1, 0, 2321, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 2774, -2, 0, 0, 2321, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 2774, -2, 1, 0, 2321, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 2774, -2, 2, 0, 2321, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2775, -1, -2, 0, 2321, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2775, 0, -2, 0, 2321, -1, "", 1);// 26
			AddComplexComponent( (BaseAddon) this, 2775, 1, -2, 0, 2321, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 2775, 2, -2, 0, 2321, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 2776, 3, -1, 0, 2321, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 2776, 3, 0, 0, 2321, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 2776, 3, 1, 0, 2321, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 2776, 3, 2, 0, 2321, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 2777, -1, 3, 0, 2321, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 2777, 0, 3, 0, 2321, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 2777, 1, 3, 0, 2321, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 2777, 2, 3, 0, 2321, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 5645, 4, 3, 0, 151, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 5645, 4, -2, 0, 151, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 5645, -2, 3, 0, 151, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 5645, -2, -2, 0, 151, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 5646, -2, -2, 0, 151, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 5646, 3, -2, 0, 151, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 11763, -1, -2, 0, 1854, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 2691, 0, -2, 0, 166, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 2687, 0, -1, 0, 166, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 2690, 1, -2, 0, 166, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 2686, 1, -1, 0, 166, -1, "", 1);// 72
			AddComplexComponent( (BaseAddon) this, 5646, -2, 4, 0, 151, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 5646, 3, 4, 0, 151, -1, "", 1);// 74

		}

		public ElegantbdrNSAddon( Serial serial ) : base( serial )
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

	public class ElegantbdrNSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ElegantbdrNSAddon();
			}
		}

		[Constructable]
		public ElegantbdrNSAddonDeed()
		{
			Name = "ElegantbdrNS";
		}

		public ElegantbdrNSAddonDeed( Serial serial ) : base( serial )
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