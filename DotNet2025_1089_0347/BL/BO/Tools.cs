using System.Reflection;
using System.Text;
using System.Xml.Linq;
namespace BO;


static internal class Tools
{
    public static string ToStringProperty<T>(this T obj,string prefix = "\t")
    {
        StringBuilder sb = new StringBuilder();
        Type type = obj.GetType();
        foreach (PropertyInfo prop in type.GetProperties())
        {
            var value = prop.GetValue(obj);
            if (value != null && !prop.PropertyType.IsPrimitive && prop.PropertyType != typeof(string))
            {
                sb.AppendLine($"{prefix}{prop.Name}:");
                sb.Append(ToStringProperty(value, prefix+prefix )); 
            }
            else
            {
                sb.AppendLine($"{ prefix }{prop.Name}={value},");
            }
        }
        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }
    public static TTarget Convert<TSource, TTarget>(this TSource source) where TTarget : new()
    {
        if (typeof(TTarget).Name != typeof(TSource).Name)
            throw new Exception("classes dont match");
        TTarget target = new TTarget();
        Type type = source.GetType();
        foreach (PropertyInfo prop in type.GetProperties())
        {
            PropertyInfo p = typeof(TSource).GetProperty(prop.Name);
            p.SetValue(target, prop.GetValue(source));
        }
        return target;
    }
}
