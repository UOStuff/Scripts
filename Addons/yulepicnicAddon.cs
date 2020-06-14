
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
	public class yulepicnicAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {11229, -1, -1, 1}, {6080, -1, -1, 1}, {11232, -1, -1, 1}// 1	3	5	
			, {6080, 0, -1, 1}, {6080, 1, -1, 1}, {6091, -1, -2, 1}// 10	11	12	
			, {6091, 1, -2, 1}, {6090, -2, -1, 1}, {6085, -2, -2, 1}// 13	14	15	
			, {6091, 0, -2, 1}, {11230, -1, 2, 1}, {3251, 0, 1, 1}// 16	21	22	
			, {6080, 0, 0, 1}, {6080, 0, 1, 1}, {6080, -1, 1, 1}// 23	24	26	
			, {6080, -1, 0, 1}, {6089, 0, 3, 1}, {6080, 1, 0, 1}// 27	28	31	
			, {6080, 0, 2, 1}, {6080, 1, 2, 1}, {6080, -1, 2, 1}// 32	33	35	
			, {6080, 1, 1, 1}, {6089, -1, 3, 1}, {6088, -2, 3, 1}// 36	39	40	
			, {6090, -2, 2, 1}, {6090, -2, 1, 1}, {6089, 1, 3, 1}// 41	42	43	
			, {7137, 1, 1, 7}, {6090, -2, 0, 1}, {3253, 1, 0, 1}// 45	46	47	
			, {11229, -1, 2, 1}, {6080, 2, -1, 1}, {6091, 2, -2, 1}// 49	50	52	
			, {6092, 3, -1, 1}, {6086, 3, -2, 1}, {6092, 3, 2, 1}// 53	54	57	
			, {6089, 2, 3, 1}, {6092, 3, 0, 1}, {6080, 2, 1, 1}// 60	61	62	
			, {6080, 2, 0, 1}, {6092, 3, 1, 1}, {6087, 3, 3, 1}// 63	65	66	
			, {11229, 2, 2, 1}, {6080, 2, 2, 1}, {11232, 2, 2, 1}// 68	69	72	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new yulepicnicAddonDeed();
			}
		}

		[ Constructable ]
		public yulepicnicAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 9003, -1, -2, 1, 534, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5037, 1, -1, 1, 99, -1, "a floor pillow", 1);// 4
			AddComplexComponent( (BaseAddon) this, 9003, -2, -1, 1, 234, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 9002, 0, -2, 5, 410, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 5690, 0, -1, 1, 67, -1, "Large Square Pillow", 1);// 8
			AddComplexComponent( (BaseAddon) this, 5691, 1, -1, 3, 237, -1, "Medium Square Pillow", 1);// 9
			AddComplexComponent( (BaseAddon) this, 5171, -1, -1, 7, 472, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 9003, 0, -2, 1, 443, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 4179, 1, 0, 1, 237, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 5691, -1, 1, 1, 56, -1, "Medium Square Pillow", 1);// 20
			AddComplexComponent( (BaseAddon) this, 5037, 0, 2, 1, 37, -1, "a floor pillow", 1);// 25
			AddComplexComponent( (BaseAddon) this, 5691, -1, 0, 1, 237, -1, "Medium Square Pillow", 1);// 29
			AddComplexComponent( (BaseAddon) this, 5037, -1, 0, 1, 241, -1, "a floor pillow", 1);// 30
			AddComplexComponent( (BaseAddon) this, 6571, 1, 1, 11, 0, 29, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 5171, -1, 3, 7, 2896, -1, "", 1);// 37
			AddComplexComponent( (BaseAddon) this, 5691, 1, 2, 0, 58, -1, "Medium Square Pillow", 1);// 38
			AddComplexComponent( (BaseAddon) this, 5036, 1, 2, 5, 38, -1, "a tagged pillow", 1);// 44
			AddComplexComponent( (BaseAddon) this, 4180, 0, 1, 1, 237, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 5171, 3, -1, 7, 1174, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 9003, 3, 1, 4, 558, -1, "", 1);// 55
			AddComplexComponent( (BaseAddon) this, 9002, 3, 1, 0, 900, -1, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 9003, 3, 2, 1, 498, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 5035, 2, 1, 4, 253, -1, "a tagged pillow", 1);// 59
			AddComplexComponent( (BaseAddon) this, 5037, 2, 0, 1, 237, -1, "a floor pillow", 1);// 64
			AddComplexComponent( (BaseAddon) this, 5171, 3, 3, 6, 237, -1, "", 1);// 67
			AddComplexComponent( (BaseAddon) this, 5690, 2, 1, 1, 230, -1, "Large Square Pillow", 1);// 70
			AddComplexComponent( (BaseAddon) this, 9002, 2, 3, 1, 659, -1, "", 1);// 71

		}

		public yulepicnicAddon( Serial serial ) : base( serial )
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

	public class yulepicnicAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new yulepicnicAddon();
			}
		}

		[Constructable]
		public yulepicnicAddonDeed()
		{
			Name = "yulepicnic";
		}

		public yulepicnicAddonDeed( Serial serial ) : base( serial )
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