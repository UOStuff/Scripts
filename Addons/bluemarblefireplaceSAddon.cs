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
	public class bluemarblefireplaceSAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new bluemarblefireplaceSAddonDeed();
			}
		}

		[ Constructable ]
		public bluemarblefireplaceSAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 1297 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 1297 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1297 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1297 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 669 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 669 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 670 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 1096 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 1095 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 672 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 671 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 670 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 670 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 670 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 671 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 6585 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 6584 );
			ac.Hue = 1109;
			AddComponent( ac, 0, 0, 1 );
			ac = new AddonComponent( 7067 );
			AddComponent( ac, 0, 0, 3 );
			ac = new AddonComponent( 6572 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 0, 0, 7 );
			ac = new AddonComponent( 2562 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, 2, 1, 10 );
			ac = new AddonComponent( 1297 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 1297 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 1297 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1297 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 697 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 698 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 698 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 698 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 699 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2562 );
			ac.Light = LightType.ArchedWindowEast;
			AddComponent( ac, -1, 1, 10 );

		}

		public bluemarblefireplaceSAddon( Serial serial ) : base( serial )
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

	public class bluemarblefireplaceSAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new bluemarblefireplaceSAddon();
			}
		}

		[Constructable]
		public bluemarblefireplaceSAddonDeed()
		{
			Name = "bluemarblefireplaceS";
		}

		public bluemarblefireplaceSAddonDeed( Serial serial ) : base( serial )
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