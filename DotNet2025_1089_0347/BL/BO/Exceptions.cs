
namespace BO;



[Serializable]
public class BLNotExistIdException : Exception
{
    public BLNotExistIdException(string message = "Id does not exist") : base(message) { }
    public BLNotExistIdException(int Id) : base($"ID {Id} does not exist.") {  }
    public BLNotExistIdException(Exception innerEx, string msg = "") : base(msg, innerEx) { }
}




[Serializable]
public class BLObjectNotExistException : Exception
{
    public BLObjectNotExistException(string objName = "Object") : base($"{objName} does not exist") { }
    public BLObjectNotExistException(Exception innerEx, string msg = "") : base(msg, innerEx) { }
}



[Serializable]
public class BLIdExistsException : Exception
{
    public BLIdExistsException(string message = "Id already exists") : base(message) { }
    public BLIdExistsException(int Id) : base($"ID {Id} already exists.") { }
    public BLIdExistsException(Exception innerEx, string msg = "") : base(msg, innerEx) { }
}



[Serializable]
public class BLDirectoryNotExistException : Exception
{
    public BLDirectoryNotExistException(string path = "path") : base($"The directory {path} does not exist.") { }
    public BLDirectoryNotExistException(Exception innerEx,string msg = "") : base(msg, innerEx) { }
}

[Serializable]
public class BLConfigException : Exception
{
    public BLConfigException(string msg) : base(msg) { }
    public BLConfigException(Exception innerEx,string msg = "") : base(msg, innerEx) { }
}

[Serializable]
public class BLComvertException : Exception
{
    public BLComvertException(string msg = "class dont match") : base(msg) { }
    public BLComvertException(string className1 , string className2) : base($"class {className1} does not match {className2}.") { }
}

