; ModuleID = 'marshal_methods.armeabi-v7a.ll'
source_filename = "marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android21"

%struct.MarshalMethodName = type {
	i64, ; uint64_t id
	ptr ; char* name
}

%struct.MarshalMethodsManagedClass = type {
	i32, ; uint32_t token
	ptr ; MonoClass klass
}

@assembly_image_cache = dso_local local_unnamed_addr global [46 x ptr] zeroinitializer, align 4

; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = dso_local local_unnamed_addr constant [92 x i32] [
	i32 42639949, ; 0: System.Threading.Thread => 0x28aa24d => 37
	i32 117431740, ; 1: System.Runtime.InteropServices => 0x6ffddbc => 28
	i32 205061960, ; 2: System.ComponentModel => 0xc38ff48 => 10
	i32 379916513, ; 3: System.Threading.Thread.dll => 0x16a510e1 => 37
	i32 385762202, ; 4: System.Memory.dll => 0x16fe439a => 20
	i32 395744057, ; 5: _Microsoft.Android.Resource.Designer => 0x17969339 => 0
	i32 442565967, ; 6: System.Collections => 0x1a61054f => 7
	i32 459347974, ; 7: System.Runtime.Serialization.Primitives.dll => 0x1b611806 => 29
	i32 469710990, ; 8: System.dll => 0x1bff388e => 41
	i32 498788369, ; 9: System.ObjectModel => 0x1dbae811 => 25
	i32 507640256, ; 10: MonoGame.Framework => 0x1e41f9c0 => 2
	i32 565490802, ; 11: Android => 0x21b4b472 => 3
	i32 662205335, ; 12: System.Text.Encodings.Web.dll => 0x27787397 => 33
	i32 672442732, ; 13: System.Collections.Concurrent => 0x2814a96c => 4
	i32 759454413, ; 14: System.Net.Requests => 0x2d445acd => 23
	i32 775507847, ; 15: System.IO.Compression => 0x2e394f87 => 17
	i32 804715423, ; 16: System.Data.Common => 0x2ff6fb9f => 12
	i32 823281589, ; 17: System.Private.Uri.dll => 0x311247b5 => 26
	i32 830298997, ; 18: System.IO.Compression.Brotli => 0x317d5b75 => 16
	i32 904024072, ; 19: System.ComponentModel.Primitives.dll => 0x35e25008 => 8
	i32 992768348, ; 20: System.Collections.dll => 0x3b2c715c => 7
	i32 1019214401, ; 21: System.Drawing => 0x3cbffa41 => 15
	i32 1036536393, ; 22: System.Drawing.Primitives.dll => 0x3dc84a49 => 14
	i32 1044663988, ; 23: System.Linq.Expressions.dll => 0x3e444eb4 => 18
	i32 1082857460, ; 24: System.ComponentModel.TypeConverter => 0x408b17f4 => 9
	i32 1098259244, ; 25: System => 0x41761b2c => 41
	i32 1324164729, ; 26: System.Linq => 0x4eed2679 => 19
	i32 1462112819, ; 27: System.IO.Compression.dll => 0x57261233 => 17
	i32 1480492111, ; 28: System.IO.Compression.Brotli.dll => 0x583e844f => 16
	i32 1543031311, ; 29: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 35
	i32 1639515021, ; 30: System.Net.Http.dll => 0x61b9038d => 21
	i32 1639986890, ; 31: System.Text.RegularExpressions => 0x61c036ca => 35
	i32 1657153582, ; 32: System.Runtime => 0x62c6282e => 30
	i32 1677501392, ; 33: System.Net.Primitives.dll => 0x63fca3d0 => 22
	i32 1679769178, ; 34: System.Security.Cryptography => 0x641f3e5a => 31
	i32 1780572499, ; 35: Mono.Android.Runtime.dll => 0x6a216153 => 44
	i32 1824175904, ; 36: System.Text.Encoding.Extensions => 0x6cbab720 => 32
	i32 1858542181, ; 37: System.Linq.Expressions => 0x6ec71a65 => 18
	i32 1910275211, ; 38: System.Collections.NonGeneric.dll => 0x71dc7c8b => 5
	i32 2045470958, ; 39: System.Private.Xml => 0x79eb68ee => 27
	i32 2079903147, ; 40: System.Runtime.dll => 0x7bf8cdab => 30
	i32 2090596640, ; 41: System.Numerics.Vectors => 0x7c9bf920 => 24
	i32 2127167465, ; 42: System.Console => 0x7ec9ffe9 => 11
	i32 2142473426, ; 43: System.Collections.Specialized => 0x7fb38cd2 => 6
	i32 2143790110, ; 44: System.Xml.XmlSerializer.dll => 0x7fc7a41e => 40
	i32 2193016926, ; 45: System.ObjectModel.dll => 0x82b6c85e => 25
	i32 2197552240, ; 46: MonoGame.Extended.dll => 0x82fbfc70 => 1
	i32 2201231467, ; 47: System.Net.Http => 0x8334206b => 21
	i32 2222056684, ; 48: System.Threading.Tasks.Parallel => 0x8471e4ec => 36
	i32 2305521784, ; 49: System.Private.CoreLib.dll => 0x896b7878 => 42
	i32 2320631194, ; 50: System.Threading.Tasks.Parallel.dll => 0x8a52059a => 36
	i32 2353062107, ; 51: System.Net.Primitives => 0x8c40e0db => 22
	i32 2368005991, ; 52: System.Xml.ReaderWriter.dll => 0x8d24e767 => 39
	i32 2435356389, ; 53: System.Console.dll => 0x912896e5 => 11
	i32 2475788418, ; 54: Java.Interop.dll => 0x93918882 => 43
	i32 2570120770, ; 55: System.Text.Encodings.Web => 0x9930ee42 => 33
	i32 2585220780, ; 56: System.Text.Encoding.Extensions.dll => 0x9a1756ac => 32
	i32 2617129537, ; 57: System.Private.Xml.dll => 0x9bfe3a41 => 27
	i32 2665622720, ; 58: System.Drawing.Primitives => 0x9ee22cc0 => 14
	i32 2676780864, ; 59: System.Data.Common.dll => 0x9f8c6f40 => 12
	i32 2909740682, ; 60: System.Private.CoreLib => 0xad6f1e8a => 42
	i32 2919462931, ; 61: System.Numerics.Vectors.dll => 0xae037813 => 24
	i32 2959614098, ; 62: System.ComponentModel.dll => 0xb0682092 => 10
	i32 3038032645, ; 63: _Microsoft.Android.Resource.Designer.dll => 0xb514b305 => 0
	i32 3059408633, ; 64: Mono.Android.Runtime => 0xb65adef9 => 44
	i32 3059793426, ; 65: System.ComponentModel.Primitives => 0xb660be12 => 8
	i32 3220365878, ; 66: System.Threading => 0xbff2e236 => 38
	i32 3316684772, ; 67: System.Net.Requests.dll => 0xc5b097e4 => 23
	i32 3358260929, ; 68: System.Text.Json => 0xc82afec1 => 34
	i32 3366347497, ; 69: Java.Interop => 0xc8a662e9 => 43
	i32 3471940407, ; 70: System.ComponentModel.TypeConverter.dll => 0xcef19b37 => 9
	i32 3476120550, ; 71: Mono.Android => 0xcf3163e6 => 45
	i32 3485117614, ; 72: System.Text.Json.dll => 0xcfbaacae => 34
	i32 3608519521, ; 73: System.Linq.dll => 0xd715a361 => 19
	i32 3672681054, ; 74: Mono.Android.dll => 0xdae8aa5e => 45
	i32 3748608112, ; 75: System.Diagnostics.DiagnosticSource => 0xdf6f3870 => 13
	i32 3792276235, ; 76: System.Collections.NonGeneric => 0xe2098b0b => 5
	i32 3802395368, ; 77: System.Collections.Specialized.dll => 0xe2a3f2e8 => 6
	i32 3823082795, ; 78: System.Security.Cryptography.dll => 0xe3df9d2b => 31
	i32 3831343120, ; 79: MonoGame.Framework.dll => 0xe45da810 => 2
	i32 3849253459, ; 80: System.Runtime.InteropServices.dll => 0xe56ef253 => 28
	i32 3882769740, ; 81: MonoGame.Extended => 0xe76e5d4c => 1
	i32 3896106733, ; 82: System.Collections.Concurrent.dll => 0xe839deed => 4
	i32 3928044579, ; 83: System.Xml.ReaderWriter => 0xea213423 => 39
	i32 4025784931, ; 84: System.Memory => 0xeff49a63 => 20
	i32 4073602200, ; 85: System.Threading.dll => 0xf2ce3c98 => 38
	i32 4099507663, ; 86: System.Drawing.dll => 0xf45985cf => 15
	i32 4100113165, ; 87: System.Private.Uri => 0xf462c30d => 26
	i32 4159265925, ; 88: System.Xml.XmlSerializer => 0xf7e95c85 => 40
	i32 4181436372, ; 89: System.Runtime.Serialization.Primitives => 0xf93ba7d4 => 29
	i32 4213026141, ; 90: System.Diagnostics.DiagnosticSource.dll => 0xfb1dad5d => 13
	i32 4232695587 ; 91: Android.dll => 0xfc49cf23 => 3
], align 4

@assembly_image_cache_indices = dso_local local_unnamed_addr constant [92 x i32] [
	i32 37, ; 0
	i32 28, ; 1
	i32 10, ; 2
	i32 37, ; 3
	i32 20, ; 4
	i32 0, ; 5
	i32 7, ; 6
	i32 29, ; 7
	i32 41, ; 8
	i32 25, ; 9
	i32 2, ; 10
	i32 3, ; 11
	i32 33, ; 12
	i32 4, ; 13
	i32 23, ; 14
	i32 17, ; 15
	i32 12, ; 16
	i32 26, ; 17
	i32 16, ; 18
	i32 8, ; 19
	i32 7, ; 20
	i32 15, ; 21
	i32 14, ; 22
	i32 18, ; 23
	i32 9, ; 24
	i32 41, ; 25
	i32 19, ; 26
	i32 17, ; 27
	i32 16, ; 28
	i32 35, ; 29
	i32 21, ; 30
	i32 35, ; 31
	i32 30, ; 32
	i32 22, ; 33
	i32 31, ; 34
	i32 44, ; 35
	i32 32, ; 36
	i32 18, ; 37
	i32 5, ; 38
	i32 27, ; 39
	i32 30, ; 40
	i32 24, ; 41
	i32 11, ; 42
	i32 6, ; 43
	i32 40, ; 44
	i32 25, ; 45
	i32 1, ; 46
	i32 21, ; 47
	i32 36, ; 48
	i32 42, ; 49
	i32 36, ; 50
	i32 22, ; 51
	i32 39, ; 52
	i32 11, ; 53
	i32 43, ; 54
	i32 33, ; 55
	i32 32, ; 56
	i32 27, ; 57
	i32 14, ; 58
	i32 12, ; 59
	i32 42, ; 60
	i32 24, ; 61
	i32 10, ; 62
	i32 0, ; 63
	i32 44, ; 64
	i32 8, ; 65
	i32 38, ; 66
	i32 23, ; 67
	i32 34, ; 68
	i32 43, ; 69
	i32 9, ; 70
	i32 45, ; 71
	i32 34, ; 72
	i32 19, ; 73
	i32 45, ; 74
	i32 13, ; 75
	i32 5, ; 76
	i32 6, ; 77
	i32 31, ; 78
	i32 2, ; 79
	i32 28, ; 80
	i32 1, ; 81
	i32 4, ; 82
	i32 39, ; 83
	i32 20, ; 84
	i32 38, ; 85
	i32 15, ; 86
	i32 26, ; 87
	i32 40, ; 88
	i32 29, ; 89
	i32 13, ; 90
	i32 3 ; 91
], align 4

@marshal_methods_number_of_classes = dso_local local_unnamed_addr constant i32 0, align 4

@marshal_methods_class_cache = dso_local local_unnamed_addr global [0 x %struct.MarshalMethodsManagedClass] zeroinitializer, align 4

; Names of classes in which marshal methods reside
@mm_class_names = dso_local local_unnamed_addr constant [0 x ptr] zeroinitializer, align 4

@mm_method_names = dso_local local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		ptr @.MarshalMethodName.0_name; char* name
	} ; 0
], align 8

; get_function_pointer (uint32_t mono_image_index, uint32_t class_index, uint32_t method_token, void*& target_ptr)
@get_function_pointer = internal dso_local unnamed_addr global ptr null, align 4

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
	store ptr %fn, ptr @get_function_pointer, align 4, !tbaa !3
	ret void
}

; Strings
@.str.0 = private unnamed_addr constant [40 x i8] c"get_function_pointer MUST be specified\0A\00", align 1

;MarshalMethodName
@.MarshalMethodName.0_name = private unnamed_addr constant [1 x i8] c"\00", align 1

; External functions

; Function attributes: noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8"
declare void @abort() local_unnamed_addr #2

; Function attributes: nofree nounwind
declare noundef i32 @puts(ptr noundef) local_unnamed_addr #1
attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn }
attributes #1 = { nofree nounwind }
attributes #2 = { noreturn "no-trapping-math"="true" nounwind "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-thumb-mode,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }

; Metadata
!llvm.module.flags = !{!0, !1, !7}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.1xx @ af27162bee43b7fecdca59b4f67aa8c175cbc875"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"min_enum_size", i32 4}
