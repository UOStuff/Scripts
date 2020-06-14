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
	public class BalloonsDAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BalloonsDAddonDeed();
			}
		}

		[ Constructable ]
		public BalloonsDAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 13932 );
			ac.Hue = 1166;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 1152;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 563 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2941;
			AddComponent( ac, 1, 1, 12 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 1161;
			AddComponent( ac, -1, -1, 0 );

		}

		public BalloonsDAddon( Serial serial ) : base( serial )
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

	public class BalloonsDAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BalloonsDAddon();
			}
		}

		[Constructable]
		public BalloonsDAddonDeed()
		{
			Name = "BalloonsD";
		}

		public BalloonsDAddonDeed( Serial serial ) : base( serial )
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