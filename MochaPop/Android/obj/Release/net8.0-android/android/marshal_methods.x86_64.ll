; ModuleID = 'marshal_methods.x86_64.ll'
source_filename = "marshal_methods.x86_64.ll"
target datalayout = "e-m:e-p270:32:32-p271:32:32-p272:64:64-i64:64-f80:128-n8:16:32:64-S128"
target triple = "x86_64-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [46 x ptr] zeroinitializer, align 16

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [92 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 45
	i64 196720943101637631, ; 1: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 18
	i64 750875890346172408, ; 2: System.Threading.Thread => 0xa6ba5a4da7d1ff8 => 37
	i64 799765834175365804, ; 3: System.ComponentModel.dll => 0xb1956c9f18442ac => 10
	i64 1268860745194512059, ; 4: System.Drawing.dll => 0x119be62002c19ebb => 15
	i64 1476839205573959279, ; 5: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 22
	i64 1504936878279068071, ; 6: MonoGame.Extended.dll => 0x14e29c1e073589a7 => 1
	i64 1513467482682125403, ; 7: Mono.Android.Runtime => 0x1500eaa8245f6c5b => 44
	i64 1537168428375924959, ; 8: System.Threading.Thread.dll => 0x15551e8a954ae0df => 37
	i64 1743969030606105336, ; 9: System.Memory.dll => 0x1833d297e88f2af8 => 20
	i64 1767386781656293639, ; 10: System.Private.Uri.dll => 0x188704e9f5582107 => 26
	i64 1875417405349196092, ; 11: System.Drawing.Primitives => 0x1a06d2319b6c713c => 14
	i64 2102659300918482391, ; 12: System.Drawing.Primitives.dll => 0x1d2e257e6aead5d7 => 14
	i64 2287834202362508563, ; 13: System.Collections.Concurrent => 0x1fc00515e8ce7513 => 4
	i64 2335503487726329082, ; 14: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 33
	i64 2497223385847772520, ; 15: System.Runtime => 0x22a7eb7046413568 => 30
	i64 3311221304742556517, ; 16: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 24
	i64 3551103847008531295, ; 17: System.Private.CoreLib.dll => 0x31480e226177735f => 42
	i64 3571415421602489686, ; 18: System.Runtime.dll => 0x319037675df7e556 => 30
	i64 3647754201059316852, ; 19: System.Xml.ReaderWriter => 0x329f6d1e86145474 => 39
	i64 3933965368022646939, ; 20: System.Net.Requests => 0x369840a8bfadc09b => 23
	i64 3966267475168208030, ; 21: System.Memory => 0x370b03412596249e => 20
	i64 4009997192427317104, ; 22: System.Runtime.Serialization.Primitives => 0x37a65f335cf1a770 => 29
	i64 4073500526318903918, ; 23: System.Private.Xml.dll => 0x3887fb25779ae26e => 27
	i64 4154383907710350974, ; 24: System.ComponentModel => 0x39a7562737acb67e => 10
	i64 4187479170553454871, ; 25: System.Linq.Expressions => 0x3a1cea1e912fa117 => 18
	i64 4205801962323029395, ; 26: System.ComponentModel.TypeConverter => 0x3a5e0299f7e7ad93 => 9
	i64 4716677666592453464, ; 27: System.Xml.XmlSerializer => 0x417501590542f358 => 40
	i64 4783864354832935512, ; 28: MonoGame.Framework => 0x4263b348e3786a58 => 2
	i64 4809057822547766521, ; 29: System.Drawing => 0x42bd349c3145ecf9 => 15
	i64 5103417709280584325, ; 30: System.Collections.Specialized => 0x46d2fb5e161b6285 => 6
	i64 5182934613077526976, ; 31: System.Collections.Specialized.dll => 0x47ed7b91fa9009c0 => 6
	i64 5570799893513421663, ; 32: System.IO.Compression.Brotli => 0x4d4f74fcdfa6c35f => 16
	i64 5573260873512690141, ; 33: System.Security.Cryptography.dll => 0x4d58333c6e4ea1dd => 31
	i64 6222399776351216807, ; 34: System.Text.Json.dll => 0x565a67a0ffe264a7 => 34
	i64 6357457916754632952, ; 35: _Microsoft.Android.Resource.Designer => 0x583a3a4ac2a7a0f8 => 0
	i64 6894844156784520562, ; 36: System.Numerics.Vectors => 0x5faf683aead1ad72 => 24
	i64 7060896174307865760, ; 37: System.Threading.Tasks.Parallel.dll => 0x61fd57a90988f4a0 => 36
	i64 7270811800166795866, ; 38: System.Linq => 0x64e71ccf51a90a5a => 19
	i64 7377312882064240630, ; 39: System.ComponentModel.TypeConverter.dll => 0x66617afac45a2ff6 => 9
	i64 7489048572193775167, ; 40: System.ObjectModel => 0x67ee71ff6b419e3f => 25
	i64 7654504624184590948, ; 41: System.Net.Http => 0x6a3a4366801b8264 => 21
	i64 7714652370974252055, ; 42: System.Private.CoreLib => 0x6b0ff375198b9c17 => 42
	i64 8064050204834738623, ; 43: System.Collections.dll => 0x6fe942efa61731bf => 7
	i64 8087206902342787202, ; 44: System.Diagnostics.DiagnosticSource => 0x703b87d46f3aa082 => 13
	i64 8167236081217502503, ; 45: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 43
	i64 8185542183669246576, ; 46: System.Collections => 0x7198e33f4794aa70 => 7
	i64 8368701292315763008, ; 47: System.Security.Cryptography => 0x7423997c6fd56140 => 31
	i64 8563666267364444763, ; 48: System.Private.Uri => 0x76d841191140ca5b => 26
	i64 8626175481042262068, ; 49: Java.Interop => 0x77b654e585b55834 => 43
	i64 8725526185868997716, ; 50: System.Diagnostics.DiagnosticSource.dll => 0x79174bd613173454 => 13
	i64 9659729154652888475, ; 51: System.Text.RegularExpressions => 0x860e407c9991dd9b => 35
	i64 9702891218465930390, ; 52: System.Collections.NonGeneric.dll => 0x86a79827b2eb3c96 => 5
	i64 9808709177481450983, ; 53: Mono.Android.dll => 0x881f890734e555e7 => 45
	i64 10038780035334861115, ; 54: System.Net.Http.dll => 0x8b50e941206af13b => 21
	i64 10051358222726253779, ; 55: System.Private.Xml => 0x8b7d990c97ccccd3 => 27
	i64 10105485790837105934, ; 56: System.Threading.Tasks.Parallel => 0x8c3de5c91d9a650e => 36
	i64 10785150219063592792, ; 57: System.Net.Primitives => 0x95ac8cfb68830758 => 22
	i64 11347436699239206956, ; 58: System.Xml.XmlSerializer.dll => 0x9d7a318e8162502c => 40
	i64 11485890710487134646, ; 59: System.Runtime.InteropServices => 0x9f6614bf0f8b71b6 => 28
	i64 11592751623319371637, ; 60: Android => 0xa0e1ba2e2d48bf75 => 3
	i64 12145679461940342714, ; 61: System.Text.Json => 0xa88e1f1ebcb62fba => 34
	i64 12201331334810686224, ; 62: System.Runtime.Serialization.Primitives.dll => 0xa953d6341e3bd310 => 29
	i64 12475113361194491050, ; 63: _Microsoft.Android.Resource.Designer.dll => 0xad2081818aba1caa => 0
	i64 12550732019250633519, ; 64: System.IO.Compression => 0xae2d28465e8e1b2f => 17
	i64 12708922737231849740, ; 65: System.Text.Encoding.Extensions => 0xb05f29e50e96e90c => 32
	i64 13213792660976503113, ; 66: Android.dll => 0xb760d26a5d2b0949 => 3
	i64 13343850469010654401, ; 67: Mono.Android.Runtime.dll => 0xb92ee14d854f44c1 => 44
	i64 13717397318615465333, ; 68: System.ComponentModel.Primitives.dll => 0xbe5dfc2ef2f87d75 => 8
	i64 13881769479078963060, ; 69: System.Console.dll => 0xc0a5f3cade5c6774 => 11
	i64 14125464355221830302, ; 70: System.Threading.dll => 0xc407bafdbc707a9e => 38
	i64 14254574811015963973, ; 71: System.Text.Encoding.Extensions.dll => 0xc5d26c4442d66545 => 32
	i64 14461014870687870182, ; 72: System.Net.Requests.dll => 0xc8afd8683afdece6 => 23
	i64 14551742072151931844, ; 73: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 33
	i64 14843517874685189901, ; 74: MonoGame.Framework.dll => 0xcdfec4dcd9c59f0d => 2
	i64 14987728460634540364, ; 75: System.IO.Compression.dll => 0xcfff1ba06622494c => 17
	i64 15076659072870671916, ; 76: System.ObjectModel.dll => 0xd13b0d8c1620662c => 25
	i64 15115185479366240210, ; 77: System.IO.Compression.Brotli.dll => 0xd1c3ed1c1bc467d2 => 16
	i64 15133485256822086103, ; 78: System.Linq.dll => 0xd204f0a9127dd9d7 => 19
	i64 15527772828719725935, ; 79: System.Console => 0xd77dbb1e38cd3d6f => 11
	i64 15609085926864131306, ; 80: System.dll => 0xd89e9cf3334914ea => 41
	i64 15661133872274321916, ; 81: System.Xml.ReaderWriter.dll => 0xd9578647d4bfb1fc => 39
	i64 16154507427712707110, ; 82: System => 0xe03056ea4e39aa26 => 41
	i64 16856067890322379635, ; 83: System.Data.Common.dll => 0xe9ecc87060889373 => 12
	i64 16890310621557459193, ; 84: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 35
	i64 17008137082415910100, ; 85: System.Collections.NonGeneric => 0xec090a90408c8cd4 => 5
	i64 17062143951396181894, ; 86: System.ComponentModel.Primitives => 0xecc8e986518c9786 => 8
	i64 17260702271250283638, ; 87: System.Data.Common => 0xef8a5543bba6bc76 => 12
	i64 17416401797122640284, ; 88: MonoGame.Extended => 0xf1b37d288ef8499c => 1
	i64 17712670374920797664, ; 89: System.Runtime.InteropServices.dll => 0xf5d00bdc38bd3de0 => 28
	i64 18025913125965088385, ; 90: System.Threading => 0xfa28e87b91334681 => 38
	i64 18245806341561545090 ; 91: System.Collections.Concurrent.dll => 0xfd3620327d587182 => 4
], align 16

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [92 x i32] [
	i32 45, ; 0
	i32 18, ; 1
	i32 37, ; 2
	i32 10, ; 3
	i32 15, ; 4
	i32 22, ; 5
	i32 1, ; 6
	i32 44, ; 7
	i32 37, ; 8
	i32 20, ; 9
	i32 26, ; 10
	i32 14, ; 11
	i32 14, ; 12
	i32 4, ; 13
	i32 33, ; 14
	i32 30, ; 15
	i32 24, ; 16
	i32 42, ; 17
	i32 30, ; 18
	i32 39, ; 19
	i32 23, ; 20
	i32 20, ; 21
	i32 29, ; 22
	i32 27, ; 23
	i32 10, ; 24
	i32 18, ; 25
	i32 9, ; 26
	i32 40, ; 27
	i32 2, ; 28
	i32 15, ; 29
	i32 6, ; 30
	i32 6, ; 31
	i32 16, ; 32
	i32 31, ; 33
	i32 34, ; 34
	i32 0, ; 35
	i32 24, ; 36
	i32 36, ; 37
	i32 19, ; 38
	i32 9, ; 39
	i32 25, ; 40
	i32 21, ; 41
	i32 42, ; 42
	i32 7, ; 43
	i32 13, ; 44
	i32 43, ; 45
	i32 7, ; 46
	i32 31, ; 47
	i32 26, ; 48
	i32 43, ; 49
	i32 13, ; 50
	i32 35, ; 51
	i32 5, ; 52
	i32 45, ; 53
	i32 21, ; 54
	i32 27, ; 55
	i32 36, ; 56
	i32 22, ; 57
	i32 40, ; 58
	i32 28, ; 59
	i32 3, ; 60
	i32 34, ; 61
	i32 29, ; 62
	i32 0, ; 63
	i32 17, ; 64
	i32 32, ; 65
	i32 3, ; 66
	i32 44, ; 67
	i32 8, ; 68
	i32 11, ; 69
	i32 38, ; 70
	i32 32, ; 71
	i32 23, ; 72
	i32 33, ; 73
	i32 2, ; 74
	i32 17, ; 75
	i32 25, ; 76
	i32 16, ; 77
	i32 19, ; 78
	i32 11, ; 79
	i32 41, ; 80
	i32 39, ; 81
	i32 41, ; 82
	i32 12, ; 83
	i32 35, ; 84
	i32 5, ; 85
	i32 8, ; 86
	i32 12, ; 87
	i32 1, ; 88
	i32 28, ; 89
	i32 38, ; 90
	i32 4 ; 91
], align 16

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 8

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 8

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 8

; Functions

; Function attributes: "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" uwtable willreturn
define void @xamarin_app_init(ptr nocapture noundef readnone %env, ptr noundef %fn) local_unnamed_addr #0
{
	%fnIsNull = icmp eq ptr %fn, null
	br i1 %fnIsNull, label %1, label %2

1: ; preds = %0
	%putsResult = call noundef i32 @puts(ptr @.str.0)
	call void @abort()
	unreachable 

2: ; preds = %1, %0
	store ptr %fn, ptr @get_function_pointer, align 8, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 16

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="x86-64" "target-features"="+crc32,+cx16,+cx8,+fxsr,+mmx,+popcnt,+sse,+sse2,+sse3,+sse4.1,+sse4.2,+ssse3,+x87" "tune-cpu"="generic" }

; Metadata
!llvm.module.flags = !{!0, !1}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.1xx @ af27162bee43b7fecdca59b4f67aa8c175cbc875"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
