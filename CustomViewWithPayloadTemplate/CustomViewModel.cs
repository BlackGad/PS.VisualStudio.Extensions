namespace $rootnamespace$
{
    [DependencyRegisterAsSelf]
    public class $safeitemname$ : DependencyObject,
                                  IViewModel,
                                  IPayloadContainer
    {
public static readonly DependencyProperty PayloadProperty =
    DependencyProperty.Register("Payload",
                                typeof(string),
                                typeof($safeitemname$),
                                new FrameworkPropertyMetadata(default(string)));

public string Payload
{
    get { return (string)GetValue(PayloadProperty); }
    set { SetValue(PayloadProperty, value); }
}

object IPayloadContainer.Payload
{
    get { return Payload; }
    set { Payload = value as string; }
}

}
}