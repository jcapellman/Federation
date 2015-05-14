namespace Federation.PCL.Objects.Ships {
    public abstract class BaseShip : BaseObject {
        public override OBJECT ObjectType { get { return OBJECT.SHIP; } }
    }
}