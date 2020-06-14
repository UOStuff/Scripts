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
	public class DressingRoomPurpleAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DressingRoomPurpleAddonDeed();
			}
		}

		[ Constructable ]
		public DressingRoomPurpleAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 3577 );
			ac.Hue = 12;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2791 );
			ac.Hue = 46;
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2789 );
			ac.Hue = 46;
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 2795 );
			ac.Hue = 46;
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2794 );
			ac.Hue = 46;
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2791 );
			ac.Hue = 46;
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2794 );
			ac.Hue = 46;
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2787 );
			ac.Hue = 46;
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 2792 );
			ac.Hue = 46;
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2793 );
			ac.Hue = 46;
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2792 );
			ac.Hue = 46;
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2788 );
			ac.Hue = 46;
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2795 );
			ac.Hue = 46;
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 1 );
			ac.Hue = 46;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2604 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2795 );
			ac.Hue = 46;
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2790 );
			ac.Hue = 46;
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2539 );
			ac.Hue = 12;
			AddComponent( ac, 0, 0, 17 );
			ac = new AddonComponent( 5916 );
			ac.Hue = 12;
			AddComponent( ac, 0, 0, 16 );
			ac = new AddonComponent( 3782 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 3577 );
			AddComponent( ac, 0, 0, 12 );
			ac = new AddonComponent( 3576 );
			ac.Hue = 12;
			AddComponent( ac, 0, 0, 13 );
			ac = new AddonComponent( 2793 );
			ac.Hue = 46;
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2795 );
			ac.Hue = 46;
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 1 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 11224 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2602 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 11224 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 11223 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 11223 );
			AddComponent( ac, -1, 1, 0 );

		}

		public DressingRoomPurpleAddon( Serial serial ) : base( serial )
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

	public class DressingRoomPurpleAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DressingRoomPurpleAddon();
			}
		}

		[Constructable]
		public DressingRoomPurpleAddonDeed()
		{
			Name = "DressingRoomPurple";
		}

		public DressingRoomPurpleAddonDeed( Serial serial ) : base( serial )
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