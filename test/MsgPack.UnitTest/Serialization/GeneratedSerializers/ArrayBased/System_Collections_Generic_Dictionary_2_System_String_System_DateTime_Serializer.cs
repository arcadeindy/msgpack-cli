﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34014
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.ArrayBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class System_Collections_Generic_Dictionary_2_System_String_System_DateTime_Serializer : MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.Dictionary<string, System.DateTime>> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer2;
        
        public System_Collections_Generic_Dictionary_2_System_String_System_DateTime_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            this._serializer0 = context.GetSerializer<string>();
            this._serializer1 = context.GetSerializer<System.DateTime>();
            this._serializer2 = context.GetSerializer<System.Nullable<System.DateTime>>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, System.Collections.Generic.Dictionary<string, System.DateTime> objectTree) {
            packer.PackMapHeader(objectTree.Count);
            System.Collections.Generic.Dictionary<string, System.DateTime>.Enumerator enumerator = objectTree.GetEnumerator();
            System.Collections.Generic.KeyValuePair<string, System.DateTime> current;
            try {
                for (
                ; enumerator.MoveNext(); 
                ) {
                    current = enumerator.Current;
                    this._serializer0.PackTo(packer, current.Key);
                    this._serializer1.PackTo(packer, current.Value);
                }
            }
            finally {
                enumerator.Dispose();
            }
        }
        
        protected internal override System.Collections.Generic.Dictionary<string, System.DateTime> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsMapHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotMapHeader();
            }
            System.Collections.Generic.Dictionary<string, System.DateTime> collection = default(System.Collections.Generic.Dictionary<string, System.DateTime>);
            collection = new System.Collections.Generic.Dictionary<string, System.DateTime>(MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker));
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, System.Collections.Generic.Dictionary<string, System.DateTime> collection) {
            if ((unpacker.IsMapHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotMapHeader();
            }
            int itemsCount = default(int);
            itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < itemsCount); i = (i + 1)) {
                string key = default(string);
                System.DateTime value = default(System.DateTime);
                string nullable = default(string);
                nullable = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(System.Collections.Generic.Dictionary<string, System.DateTime>), string.Format(System.Globalization.CultureInfo.InvariantCulture, "key{0}", new object[] {
                                ((object)(i))}));
                if (((nullable == null) 
                            == false)) {
                    key = nullable;
                }
                else {
                    throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited(string.Format(System.Globalization.CultureInfo.InvariantCulture, "key{0}", new object[] {
                                    ((object)(i))}));
                }
                System.Nullable<System.DateTime> nullable0 = default(System.Nullable<System.DateTime>);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable0 = this._serializer2.UnpackFrom(unpacker);
                }
                else {
                    MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                    disposable = unpacker.ReadSubtree();
                    try {
                        nullable0 = this._serializer2.UnpackFrom(disposable);
                    }
                    finally {
                        if (((disposable == null) 
                                    == false)) {
                            disposable.Dispose();
                        }
                    }
                }
                if (nullable0.HasValue) {
                    value = nullable0.Value;
                }
                else {
                    throw MsgPack.Serialization.SerializationExceptions.NewValueTypeCannotBeNull(string.Format(System.Globalization.CultureInfo.InvariantCulture, "value{0}", new object[] {
                                    ((object)(i))}), typeof(System.DateTime), typeof(System.Collections.Generic.Dictionary<string, System.DateTime>));
                }
                collection.Add(key, value);
            }
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
