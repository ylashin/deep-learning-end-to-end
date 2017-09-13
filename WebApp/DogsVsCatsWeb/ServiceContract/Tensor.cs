// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensor.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensor.proto</summary>
  public static partial class TensorReflection {

    #region Descriptor
    /// <summary>File descriptor for tensor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TensorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgx0ZW5zb3IucHJvdG8SCnRlbnNvcmZsb3caFXJlc291cmNlX2hhbmRsZS5w",
            "cm90bxoSdGVuc29yX3NoYXBlLnByb3RvGgt0eXBlcy5wcm90byKeAwoLVGVu",
            "c29yUHJvdG8SIwoFZHR5cGUYASABKA4yFC50ZW5zb3JmbG93LkRhdGFUeXBl",
            "EjIKDHRlbnNvcl9zaGFwZRgCIAEoCzIcLnRlbnNvcmZsb3cuVGVuc29yU2hh",
            "cGVQcm90bxIWCg52ZXJzaW9uX251bWJlchgDIAEoBRIWCg50ZW5zb3JfY29u",
            "dGVudBgEIAEoDBIUCghoYWxmX3ZhbBgNIAMoBUICEAESFQoJZmxvYXRfdmFs",
            "GAUgAygCQgIQARIWCgpkb3VibGVfdmFsGAYgAygBQgIQARITCgdpbnRfdmFs",
            "GAcgAygFQgIQARISCgpzdHJpbmdfdmFsGAggAygMEhgKDHNjb21wbGV4X3Zh",
            "bBgJIAMoAkICEAESFQoJaW50NjRfdmFsGAogAygDQgIQARIUCghib29sX3Zh",
            "bBgLIAMoCEICEAESGAoMZGNvbXBsZXhfdmFsGAwgAygBQgIQARI3ChNyZXNv",
            "dXJjZV9oYW5kbGVfdmFsGA4gAygLMhoudGVuc29yZmxvdy5SZXNvdXJjZUhh",
            "bmRsZUItChhvcmcudGVuc29yZmxvdy5mcmFtZXdvcmtCDFRlbnNvclByb3Rv",
            "c1AB+AEBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.ResourceHandleReflection.Descriptor, global::Tensorflow.TensorShapeReflection.Descriptor, global::Tensorflow.TypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.TensorProto), global::Tensorflow.TensorProto.Parser, new[]{ "Dtype", "TensorShape", "VersionNumber", "TensorContent", "HalfVal", "FloatVal", "DoubleVal", "IntVal", "StringVal", "ScomplexVal", "Int64Val", "BoolVal", "DcomplexVal", "ResourceHandleVal" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Protocol buffer representing a tensor.
  /// </summary>
  public sealed partial class TensorProto : pb::IMessage<TensorProto> {
    private static readonly pb::MessageParser<TensorProto> _parser = new pb::MessageParser<TensorProto>(() => new TensorProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TensorProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.TensorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorProto(TensorProto other) : this() {
      dtype_ = other.dtype_;
      TensorShape = other.tensorShape_ != null ? other.TensorShape.Clone() : null;
      versionNumber_ = other.versionNumber_;
      tensorContent_ = other.tensorContent_;
      halfVal_ = other.halfVal_.Clone();
      floatVal_ = other.floatVal_.Clone();
      doubleVal_ = other.doubleVal_.Clone();
      intVal_ = other.intVal_.Clone();
      stringVal_ = other.stringVal_.Clone();
      scomplexVal_ = other.scomplexVal_.Clone();
      int64Val_ = other.int64Val_.Clone();
      boolVal_ = other.boolVal_.Clone();
      dcomplexVal_ = other.dcomplexVal_.Clone();
      resourceHandleVal_ = other.resourceHandleVal_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorProto Clone() {
      return new TensorProto(this);
    }

    /// <summary>Field number for the "dtype" field.</summary>
    public const int DtypeFieldNumber = 1;
    private global::Tensorflow.DataType dtype_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.DataType Dtype {
      get { return dtype_; }
      set {
        dtype_ = value;
      }
    }

    /// <summary>Field number for the "tensor_shape" field.</summary>
    public const int TensorShapeFieldNumber = 2;
    private global::Tensorflow.TensorShapeProto tensorShape_;
    /// <summary>
    /// Shape of the tensor.  TODO(touts): sort out the 0-rank issues.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.TensorShapeProto TensorShape {
      get { return tensorShape_; }
      set {
        tensorShape_ = value;
      }
    }

    /// <summary>Field number for the "version_number" field.</summary>
    public const int VersionNumberFieldNumber = 3;
    private int versionNumber_;
    /// <summary>
    /// Version number.
    ///
    /// In version 0, if the "repeated xxx" representations contain only one
    /// element, that element is repeated to fill the shape.  This makes it easy
    /// to represent a constant Tensor with a single value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int VersionNumber {
      get { return versionNumber_; }
      set {
        versionNumber_ = value;
      }
    }

    /// <summary>Field number for the "tensor_content" field.</summary>
    public const int TensorContentFieldNumber = 4;
    private pb::ByteString tensorContent_ = pb::ByteString.Empty;
    /// <summary>
    /// Serialized content from Tensor::AsProtoTensorContent(). This representation
    /// can be used for all tensor types.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString TensorContent {
      get { return tensorContent_; }
      set {
        tensorContent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "half_val" field.</summary>
    public const int HalfValFieldNumber = 13;
    private static readonly pb::FieldCodec<int> _repeated_halfVal_codec
        = pb::FieldCodec.ForInt32(106);
    private readonly pbc::RepeatedField<int> halfVal_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// DT_HALF. Note that since protobuf has no int16 type, we'll have some
    /// pointless zero padding for each value here.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> HalfVal {
      get { return halfVal_; }
    }

    /// <summary>Field number for the "float_val" field.</summary>
    public const int FloatValFieldNumber = 5;
    private static readonly pb::FieldCodec<float> _repeated_floatVal_codec
        = pb::FieldCodec.ForFloat(42);
    private readonly pbc::RepeatedField<float> floatVal_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// DT_FLOAT.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> FloatVal {
      get { return floatVal_; }
    }

    /// <summary>Field number for the "double_val" field.</summary>
    public const int DoubleValFieldNumber = 6;
    private static readonly pb::FieldCodec<double> _repeated_doubleVal_codec
        = pb::FieldCodec.ForDouble(50);
    private readonly pbc::RepeatedField<double> doubleVal_ = new pbc::RepeatedField<double>();
    /// <summary>
    /// DT_DOUBLE.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> DoubleVal {
      get { return doubleVal_; }
    }

    /// <summary>Field number for the "int_val" field.</summary>
    public const int IntValFieldNumber = 7;
    private static readonly pb::FieldCodec<int> _repeated_intVal_codec
        = pb::FieldCodec.ForInt32(58);
    private readonly pbc::RepeatedField<int> intVal_ = new pbc::RepeatedField<int>();
    /// <summary>
    /// DT_INT32, DT_INT16, DT_INT8, DT_UINT8.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> IntVal {
      get { return intVal_; }
    }

    /// <summary>Field number for the "string_val" field.</summary>
    public const int StringValFieldNumber = 8;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_stringVal_codec
        = pb::FieldCodec.ForBytes(66);
    private readonly pbc::RepeatedField<pb::ByteString> stringVal_ = new pbc::RepeatedField<pb::ByteString>();
    /// <summary>
    /// DT_STRING
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> StringVal {
      get { return stringVal_; }
    }

    /// <summary>Field number for the "scomplex_val" field.</summary>
    public const int ScomplexValFieldNumber = 9;
    private static readonly pb::FieldCodec<float> _repeated_scomplexVal_codec
        = pb::FieldCodec.ForFloat(74);
    private readonly pbc::RepeatedField<float> scomplexVal_ = new pbc::RepeatedField<float>();
    /// <summary>
    /// DT_COMPLEX64. scomplex_val(2*i) and scomplex_val(2*i+1) are real
    /// and imaginary parts of i-th single precision complex.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> ScomplexVal {
      get { return scomplexVal_; }
    }

    /// <summary>Field number for the "int64_val" field.</summary>
    public const int Int64ValFieldNumber = 10;
    private static readonly pb::FieldCodec<long> _repeated_int64Val_codec
        = pb::FieldCodec.ForInt64(82);
    private readonly pbc::RepeatedField<long> int64Val_ = new pbc::RepeatedField<long>();
    /// <summary>
    /// DT_INT64
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<long> Int64Val {
      get { return int64Val_; }
    }

    /// <summary>Field number for the "bool_val" field.</summary>
    public const int BoolValFieldNumber = 11;
    private static readonly pb::FieldCodec<bool> _repeated_boolVal_codec
        = pb::FieldCodec.ForBool(90);
    private readonly pbc::RepeatedField<bool> boolVal_ = new pbc::RepeatedField<bool>();
    /// <summary>
    /// DT_BOOL
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<bool> BoolVal {
      get { return boolVal_; }
    }

    /// <summary>Field number for the "dcomplex_val" field.</summary>
    public const int DcomplexValFieldNumber = 12;
    private static readonly pb::FieldCodec<double> _repeated_dcomplexVal_codec
        = pb::FieldCodec.ForDouble(98);
    private readonly pbc::RepeatedField<double> dcomplexVal_ = new pbc::RepeatedField<double>();
    /// <summary>
    /// DT_COMPLEX128. dcomplex_val(2*i) and dcomplex_val(2*i+1) are real
    /// and imaginary parts of i-th double precision complex.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<double> DcomplexVal {
      get { return dcomplexVal_; }
    }

    /// <summary>Field number for the "resource_handle_val" field.</summary>
    public const int ResourceHandleValFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Tensorflow.ResourceHandle> _repeated_resourceHandleVal_codec
        = pb::FieldCodec.ForMessage(114, global::Tensorflow.ResourceHandle.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.ResourceHandle> resourceHandleVal_ = new pbc::RepeatedField<global::Tensorflow.ResourceHandle>();
    /// <summary>
    /// DT_RESOURCE
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.ResourceHandle> ResourceHandleVal {
      get { return resourceHandleVal_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TensorProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TensorProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Dtype != other.Dtype) return false;
      if (!object.Equals(TensorShape, other.TensorShape)) return false;
      if (VersionNumber != other.VersionNumber) return false;
      if (TensorContent != other.TensorContent) return false;
      if(!halfVal_.Equals(other.halfVal_)) return false;
      if(!floatVal_.Equals(other.floatVal_)) return false;
      if(!doubleVal_.Equals(other.doubleVal_)) return false;
      if(!intVal_.Equals(other.intVal_)) return false;
      if(!stringVal_.Equals(other.stringVal_)) return false;
      if(!scomplexVal_.Equals(other.scomplexVal_)) return false;
      if(!int64Val_.Equals(other.int64Val_)) return false;
      if(!boolVal_.Equals(other.boolVal_)) return false;
      if(!dcomplexVal_.Equals(other.dcomplexVal_)) return false;
      if(!resourceHandleVal_.Equals(other.resourceHandleVal_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Dtype != 0) hash ^= Dtype.GetHashCode();
      if (tensorShape_ != null) hash ^= TensorShape.GetHashCode();
      if (VersionNumber != 0) hash ^= VersionNumber.GetHashCode();
      if (TensorContent.Length != 0) hash ^= TensorContent.GetHashCode();
      hash ^= halfVal_.GetHashCode();
      hash ^= floatVal_.GetHashCode();
      hash ^= doubleVal_.GetHashCode();
      hash ^= intVal_.GetHashCode();
      hash ^= stringVal_.GetHashCode();
      hash ^= scomplexVal_.GetHashCode();
      hash ^= int64Val_.GetHashCode();
      hash ^= boolVal_.GetHashCode();
      hash ^= dcomplexVal_.GetHashCode();
      hash ^= resourceHandleVal_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Dtype != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Dtype);
      }
      if (tensorShape_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TensorShape);
      }
      if (VersionNumber != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(VersionNumber);
      }
      if (TensorContent.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(TensorContent);
      }
      floatVal_.WriteTo(output, _repeated_floatVal_codec);
      doubleVal_.WriteTo(output, _repeated_doubleVal_codec);
      intVal_.WriteTo(output, _repeated_intVal_codec);
      stringVal_.WriteTo(output, _repeated_stringVal_codec);
      scomplexVal_.WriteTo(output, _repeated_scomplexVal_codec);
      int64Val_.WriteTo(output, _repeated_int64Val_codec);
      boolVal_.WriteTo(output, _repeated_boolVal_codec);
      dcomplexVal_.WriteTo(output, _repeated_dcomplexVal_codec);
      halfVal_.WriteTo(output, _repeated_halfVal_codec);
      resourceHandleVal_.WriteTo(output, _repeated_resourceHandleVal_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Dtype != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Dtype);
      }
      if (tensorShape_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TensorShape);
      }
      if (VersionNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(VersionNumber);
      }
      if (TensorContent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(TensorContent);
      }
      size += halfVal_.CalculateSize(_repeated_halfVal_codec);
      size += floatVal_.CalculateSize(_repeated_floatVal_codec);
      size += doubleVal_.CalculateSize(_repeated_doubleVal_codec);
      size += intVal_.CalculateSize(_repeated_intVal_codec);
      size += stringVal_.CalculateSize(_repeated_stringVal_codec);
      size += scomplexVal_.CalculateSize(_repeated_scomplexVal_codec);
      size += int64Val_.CalculateSize(_repeated_int64Val_codec);
      size += boolVal_.CalculateSize(_repeated_boolVal_codec);
      size += dcomplexVal_.CalculateSize(_repeated_dcomplexVal_codec);
      size += resourceHandleVal_.CalculateSize(_repeated_resourceHandleVal_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TensorProto other) {
      if (other == null) {
        return;
      }
      if (other.Dtype != 0) {
        Dtype = other.Dtype;
      }
      if (other.tensorShape_ != null) {
        if (tensorShape_ == null) {
          tensorShape_ = new global::Tensorflow.TensorShapeProto();
        }
        TensorShape.MergeFrom(other.TensorShape);
      }
      if (other.VersionNumber != 0) {
        VersionNumber = other.VersionNumber;
      }
      if (other.TensorContent.Length != 0) {
        TensorContent = other.TensorContent;
      }
      halfVal_.Add(other.halfVal_);
      floatVal_.Add(other.floatVal_);
      doubleVal_.Add(other.doubleVal_);
      intVal_.Add(other.intVal_);
      stringVal_.Add(other.stringVal_);
      scomplexVal_.Add(other.scomplexVal_);
      int64Val_.Add(other.int64Val_);
      boolVal_.Add(other.boolVal_);
      dcomplexVal_.Add(other.dcomplexVal_);
      resourceHandleVal_.Add(other.resourceHandleVal_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            dtype_ = (global::Tensorflow.DataType) input.ReadEnum();
            break;
          }
          case 18: {
            if (tensorShape_ == null) {
              tensorShape_ = new global::Tensorflow.TensorShapeProto();
            }
            input.ReadMessage(tensorShape_);
            break;
          }
          case 24: {
            VersionNumber = input.ReadInt32();
            break;
          }
          case 34: {
            TensorContent = input.ReadBytes();
            break;
          }
          case 42:
          case 45: {
            floatVal_.AddEntriesFrom(input, _repeated_floatVal_codec);
            break;
          }
          case 50:
          case 49: {
            doubleVal_.AddEntriesFrom(input, _repeated_doubleVal_codec);
            break;
          }
          case 58:
          case 56: {
            intVal_.AddEntriesFrom(input, _repeated_intVal_codec);
            break;
          }
          case 66: {
            stringVal_.AddEntriesFrom(input, _repeated_stringVal_codec);
            break;
          }
          case 74:
          case 77: {
            scomplexVal_.AddEntriesFrom(input, _repeated_scomplexVal_codec);
            break;
          }
          case 82:
          case 80: {
            int64Val_.AddEntriesFrom(input, _repeated_int64Val_codec);
            break;
          }
          case 90:
          case 88: {
            boolVal_.AddEntriesFrom(input, _repeated_boolVal_codec);
            break;
          }
          case 98:
          case 97: {
            dcomplexVal_.AddEntriesFrom(input, _repeated_dcomplexVal_codec);
            break;
          }
          case 106:
          case 104: {
            halfVal_.AddEntriesFrom(input, _repeated_halfVal_codec);
            break;
          }
          case 114: {
            resourceHandleVal_.AddEntriesFrom(input, _repeated_resourceHandleVal_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code