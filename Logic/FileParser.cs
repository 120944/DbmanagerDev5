using System;
using System.IO;

namespace Logic {
  public class FileParser : IDisposable {
    private string _sourceString;
    private FileStream _sourceStream;

    private enum Type { STRING, FILESTREAM }
    private Type _type;

    public FileParser(string source) {
      _type = Type.STRING;
      _sourceString = source;
    }

    public FileParser(FileStream source) {
      _type = Type.FILESTREAM;
      _sourceStream = source;
    }

    public string ValueFor(string label) {
      string value = "";
      switch (_type) {
        case Type.STRING:
          value = ValueFor(label, _sourceString);
          return value;
        case Type.FILESTREAM:
          throw new NotImplementedException();
      }
      return value;
    }

    public static string ValueFor(string label, string source) {
      var properties = source.Split('\n');

      foreach (var property in properties) {
        var keyValue = property.Split('=',':');
        return keyValue[1];
      }
      return "";
    }

    public static string ValueFor(string label, FileStream source) {
      throw new NotImplementedException();
    }

    public void Dispose() {
      GC.SuppressFinalize(this);
    }
  }
}