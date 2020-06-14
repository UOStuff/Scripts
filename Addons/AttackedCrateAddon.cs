/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class AttackedCrateAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new AttackedCrateAddonDeed();
			}
		}

		[ Constructable ]
		public AttackedCrateAddon()
		{
			AddComponent( new AddonComponent( 3253 ), -6, 4, 1 );
			AddComponent( new AddonComponent( 3342 ), 5, 4, 1 );
			AddComponent( new AddonComponent( 3248 ), 4, 1, 1 );
			AddComponent( new AddonComponent( 3315 ), 2, 4, 1 );
			AddComponent( new AddonComponent( 3247 ), 3, 3, 1 );
			AddComponent( new AddonComponent( 3247 ), 7, 4, 1 );
			AddComponent( new AddonComponent( 3253 ), 1, 3, 1 );
			AddComponent( new AddonComponent( 3247 ), -3, 4, 1 );
			AddComponent( new AddonComponent( 3248 ), 4, 3, 1 );
			AddComponent( new AddonComponent( 3253 ), -4, 3, 1 );
			AddComponent( new AddonComponent( 3288 ), -4, 2, 1 );
			AddComponent( new AddonComponent( 3289 ), -4, 2, 1 );
			AddComponent( new AddonComponent( 3253 ), 7, 1, 1 );
			AddonComponent ac;
			ac = new AddonComponent( 16000 );
			ac.Hue = 1854;
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 6406 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 16001 );
			ac.Hue = 1854;
			AddComponent( ac, 0, -1, 3 );
			ac = new AddonComponent( 3646 );
			ac.Hue = 1622;
			AddComponent( ac, -1, -1, 3 );
			ac = new AddonComponent( 7796 );
			ac.Hue = 1854;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 7861 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 2473 );
			AddComponent( ac, -6, 1, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, -1, -2, 2 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 0, -1, 3 );
			ac = new AddonComponent( 4154 );
			AddComponent( ac, -2, -1, 3 );
			ac = new AddonComponent( 6412 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, -3, -2, 2 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, 0, 1, 3 );
			ac = new AddonComponent( 15720 );
			AddComponent( ac, 2, 2, 1 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -2, 1, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, -2, -2, 2 );
			ac = new AddonComponent( 7072 );
			AddComponent( ac, -4, 2, 0 );
			ac = new AddonComponent( 7796 );
			ac.Hue = 1854;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 1993 );
			AddComponent( ac, 1, -1, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, -2, 1, 3 );
			ac = new AddonComponent( 3391 );
			AddComponent( ac, -3, 1, 0 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle300;
			AddComponent( ac, -3, 1, 5 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, 0, -2, 2 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -1, -1, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -2, 0, 3 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, -4, -1, 0 );
			ac = new AddonComponent( 6325 );
			AddComponent( ac, -4, -2, 0 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -2, -1, 3 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -3, 0, 3 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, 1, -1, 3 );
			ac = new AddonComponent( 15719 );
			AddComponent( ac, -5, -2, 1 );
			ac = new AddonComponent( 7075 );
			AddComponent( ac, -5, -1, 0 );
			ac = new AddonComponent( 1993 );
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 123420 );
			AddComponent( ac, 3, -3, 0 );
			ac = new AddonComponent( 7604 );
			AddComponent( ac, -6, -1, 0 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 15720 );
			AddComponent( ac, 2, -3, 1 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle300;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 6355 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -3, -1, 3 );
			ac = new AddonComponent( 2176 );
			AddComponent( ac, 1, -2, 2 );
			ac = new AddonComponent( 7603 );
			AddComponent( ac, -6, 0, 0 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle300;
			AddComponent( ac, -4, 0, 0 );
			ac = new AddonComponent( 6571 );
			ac.Light = LightType.Circle300;
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 6272 );
			AddComponent( ac, -2, 0, 3 );
			ac = new AddonComponent( 4651 );
			AddComponent( ac, 1, 0, 2 );
			ac = new AddonComponent( 1994 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 6409 );
			AddComponent( ac, -4, 1, 0 );
			ac = new AddonComponent( 14742 );
			ac.Light = LightType.Circle225;
			AddComponent( ac, -1, 0, 1 );
			ac = new AddonComponent( 7825 );
			AddComponent( ac, 6, 0, 1 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 4, 0, 0 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 4, -1, 0 );
			ac = new AddonComponent( 7825 );
			AddComponent( ac, 6, 1, 1 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 6, -1, 0 );
			ac = new AddonComponent( 3722 );
			AddComponent( ac, 6, 0, 0 );
			ac = new AddonComponent( 7825 );
			AddComponent( ac, 4, 1, 1 );
			ac = new AddonComponent( 7825 );
			AddComponent( ac, 4, 0, 1 );

		}

		public AttackedCrateAddon( Serial serial ) : base( serial )
		{
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

	public class AttackedCrateAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new AttackedCrateAddon();
			}
		}

		[Constructable]
		public AttackedCrateAddonDeed()
		{
			Name = "AttackedCrate";
		}

		public AttackedCrateAddonDeed( Serial serial ) : base( serial )
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