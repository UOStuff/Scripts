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
	public class BalloonsEAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new BalloonsEAddonDeed();
			}
		}

		[ Constructable ]
		public BalloonsEAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 13932 );
			ac.Hue = 1163;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2944;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 2946;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 875 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 13932 );
			ac.Hue = 1153;
			AddComponent( ac, 1, 1, 12 );

		}

		public BalloonsEAddon( Serial serial ) : base( serial )
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

	public class BalloonsEAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new BalloonsEAddon();
			}
		}

		[Constructable]
		public BalloonsEAddonDeed()
		{
			Name = "BalloonsE";
		}

		public BalloonsEAddonDeed( Serial serial ) : base( serial )
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