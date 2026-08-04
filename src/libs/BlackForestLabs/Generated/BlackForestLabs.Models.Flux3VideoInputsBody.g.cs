#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace BlackForestLabs
{
    /// <summary>
    /// Route body wrapper: FastAPI drops the union's discriminator when the<br/>
    /// bare union is the top-level body param, so 422s enumerate every mode<br/>
    /// class instead of the one the client sent. The RootModel keeps<br/>
    /// discrimination inside pydantic; routes unwrap `.root`.
    /// </summary>
    public readonly partial struct Flux3VideoInputsBody : global::System.IEquatable<Flux3VideoInputsBody>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? Mode { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::BlackForestLabs.Flux3VideoT2VInputs? T2v { get; init; }
#else
        public global::BlackForestLabs.Flux3VideoT2VInputs? T2v { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(T2v))]
#endif
        public bool IsT2v => T2v != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickT2v(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::BlackForestLabs.Flux3VideoT2VInputs? value)
        {
            value = T2v;
            return IsT2v;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::BlackForestLabs.Flux3VideoT2VInputs PickT2v() => IsT2v
            ? T2v!
            : throw new global::System.InvalidOperationException($"Expected union variant 'T2v' but the value was {ToString()}.");

        /// <summary>
        /// Image continuation: your images become frames of the video. One image<br/>
        /// starts the video; two start and end it; with more, the first starts it,<br/>
        /// the last ends it, and the rest fall evenly in between. To control the<br/>
        /// timing yourself, send `[seconds, image]` pairs: each image becomes the<br/>
        /// frame at that second.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::BlackForestLabs.Flux3VideoI2VInputs? I2v { get; init; }
#else
        public global::BlackForestLabs.Flux3VideoI2VInputs? I2v { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(I2v))]
#endif
        public bool IsI2v => I2v != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickI2v(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::BlackForestLabs.Flux3VideoI2VInputs? value)
        {
            value = I2v;
            return IsI2v;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::BlackForestLabs.Flux3VideoI2VInputs PickI2v() => IsI2v
            ? I2v!
            : throw new global::System.InvalidOperationException($"Expected union variant 'I2v' but the value was {ToString()}.");

        /// <summary>
        /// Video continuation: the generated clip carries on from your video's<br/>
        /// final frames.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::BlackForestLabs.Flux3VideoV2VInputs? V2v { get; init; }
#else
        public global::BlackForestLabs.Flux3VideoV2VInputs? V2v { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(V2v))]
#endif
        public bool IsV2v => V2v != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickV2v(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::BlackForestLabs.Flux3VideoV2VInputs? value)
        {
            value = V2v;
            return IsV2v;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::BlackForestLabs.Flux3VideoV2VInputs PickV2v() => IsV2v
            ? V2v!
            : throw new global::System.InvalidOperationException($"Expected union variant 'V2v' but the value was {ToString()}.");

        /// <summary>
        /// Full-quality render of a prior `draft` generation. The bundle pins the<br/>
        /// generation itself -- the original mode, prompt, seed, and conditioning<br/>
        /// media -- so `resolution` is the only output choice left to the caller.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? DraftEnhance { get; init; }
#else
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? DraftEnhance { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DraftEnhance))]
#endif
        public bool IsDraftEnhance => DraftEnhance != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDraftEnhance(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? value)
        {
            value = DraftEnhance;
            return IsDraftEnhance;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::BlackForestLabs.Flux3VideoDraftEnhanceInputs PickDraftEnhance() => IsDraftEnhance
            ? DraftEnhance!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DraftEnhance' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoT2VInputs value) => new Flux3VideoInputsBody((global::BlackForestLabs.Flux3VideoT2VInputs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::BlackForestLabs.Flux3VideoT2VInputs?(Flux3VideoInputsBody @this) => @this.T2v;

        /// <summary>
        /// 
        /// </summary>
        public Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoT2VInputs? value)
        {
            T2v = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Flux3VideoInputsBody FromT2v(global::BlackForestLabs.Flux3VideoT2VInputs? value) => new Flux3VideoInputsBody(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoI2VInputs value) => new Flux3VideoInputsBody((global::BlackForestLabs.Flux3VideoI2VInputs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::BlackForestLabs.Flux3VideoI2VInputs?(Flux3VideoInputsBody @this) => @this.I2v;

        /// <summary>
        /// 
        /// </summary>
        public Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoI2VInputs? value)
        {
            I2v = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Flux3VideoInputsBody FromI2v(global::BlackForestLabs.Flux3VideoI2VInputs? value) => new Flux3VideoInputsBody(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoV2VInputs value) => new Flux3VideoInputsBody((global::BlackForestLabs.Flux3VideoV2VInputs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::BlackForestLabs.Flux3VideoV2VInputs?(Flux3VideoInputsBody @this) => @this.V2v;

        /// <summary>
        /// 
        /// </summary>
        public Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoV2VInputs? value)
        {
            V2v = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Flux3VideoInputsBody FromV2v(global::BlackForestLabs.Flux3VideoV2VInputs? value) => new Flux3VideoInputsBody(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs value) => new Flux3VideoInputsBody((global::BlackForestLabs.Flux3VideoDraftEnhanceInputs?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::BlackForestLabs.Flux3VideoDraftEnhanceInputs?(Flux3VideoInputsBody @this) => @this.DraftEnhance;

        /// <summary>
        /// 
        /// </summary>
        public Flux3VideoInputsBody(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? value)
        {
            DraftEnhance = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Flux3VideoInputsBody FromDraftEnhance(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? value) => new Flux3VideoInputsBody(value);

        /// <summary>
        /// 
        /// </summary>
        public Flux3VideoInputsBody(
            global::BlackForestLabs.Flux3VideoInputsBodyDiscriminatorMode? mode,
            global::BlackForestLabs.Flux3VideoT2VInputs? t2v,
            global::BlackForestLabs.Flux3VideoI2VInputs? i2v,
            global::BlackForestLabs.Flux3VideoV2VInputs? v2v,
            global::BlackForestLabs.Flux3VideoDraftEnhanceInputs? draftEnhance
            )
        {
            Mode = mode;

            T2v = t2v;
            I2v = i2v;
            V2v = v2v;
            DraftEnhance = draftEnhance;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DraftEnhance as object ??
            V2v as object ??
            I2v as object ??
            T2v as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            T2v?.ToString() ??
            I2v?.ToString() ??
            V2v?.ToString() ??
            DraftEnhance?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsT2v && !IsI2v && !IsV2v && !IsDraftEnhance || !IsT2v && IsI2v && !IsV2v && !IsDraftEnhance || !IsT2v && !IsI2v && IsV2v && !IsDraftEnhance || !IsT2v && !IsI2v && !IsV2v && IsDraftEnhance;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::BlackForestLabs.Flux3VideoT2VInputs, TResult>? t2v = null,
            global::System.Func<global::BlackForestLabs.Flux3VideoI2VInputs, TResult>? i2v = null,
            global::System.Func<global::BlackForestLabs.Flux3VideoV2VInputs, TResult>? v2v = null,
            global::System.Func<global::BlackForestLabs.Flux3VideoDraftEnhanceInputs, TResult>? draftEnhance = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsT2v && t2v != null)
            {
                return t2v(T2v!);
            }
            else if (IsI2v && i2v != null)
            {
                return i2v(I2v!);
            }
            else if (IsV2v && v2v != null)
            {
                return v2v(V2v!);
            }
            else if (IsDraftEnhance && draftEnhance != null)
            {
                return draftEnhance(DraftEnhance!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::BlackForestLabs.Flux3VideoT2VInputs>? t2v = null,

            global::System.Action<global::BlackForestLabs.Flux3VideoI2VInputs>? i2v = null,

            global::System.Action<global::BlackForestLabs.Flux3VideoV2VInputs>? v2v = null,

            global::System.Action<global::BlackForestLabs.Flux3VideoDraftEnhanceInputs>? draftEnhance = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsT2v)
            {
                t2v?.Invoke(T2v!);
            }
            else if (IsI2v)
            {
                i2v?.Invoke(I2v!);
            }
            else if (IsV2v)
            {
                v2v?.Invoke(V2v!);
            }
            else if (IsDraftEnhance)
            {
                draftEnhance?.Invoke(DraftEnhance!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::BlackForestLabs.Flux3VideoT2VInputs>? t2v = null,
            global::System.Action<global::BlackForestLabs.Flux3VideoI2VInputs>? i2v = null,
            global::System.Action<global::BlackForestLabs.Flux3VideoV2VInputs>? v2v = null,
            global::System.Action<global::BlackForestLabs.Flux3VideoDraftEnhanceInputs>? draftEnhance = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsT2v)
            {
                t2v?.Invoke(T2v!);
            }
            else if (IsI2v)
            {
                i2v?.Invoke(I2v!);
            }
            else if (IsV2v)
            {
                v2v?.Invoke(V2v!);
            }
            else if (IsDraftEnhance)
            {
                draftEnhance?.Invoke(DraftEnhance!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                T2v,
                typeof(global::BlackForestLabs.Flux3VideoT2VInputs),
                I2v,
                typeof(global::BlackForestLabs.Flux3VideoI2VInputs),
                V2v,
                typeof(global::BlackForestLabs.Flux3VideoV2VInputs),
                DraftEnhance,
                typeof(global::BlackForestLabs.Flux3VideoDraftEnhanceInputs),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(Flux3VideoInputsBody other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::BlackForestLabs.Flux3VideoT2VInputs?>.Default.Equals(T2v, other.T2v) &&
                global::System.Collections.Generic.EqualityComparer<global::BlackForestLabs.Flux3VideoI2VInputs?>.Default.Equals(I2v, other.I2v) &&
                global::System.Collections.Generic.EqualityComparer<global::BlackForestLabs.Flux3VideoV2VInputs?>.Default.Equals(V2v, other.V2v) &&
                global::System.Collections.Generic.EqualityComparer<global::BlackForestLabs.Flux3VideoDraftEnhanceInputs?>.Default.Equals(DraftEnhance, other.DraftEnhance) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Flux3VideoInputsBody obj1, Flux3VideoInputsBody obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Flux3VideoInputsBody>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Flux3VideoInputsBody obj1, Flux3VideoInputsBody obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Flux3VideoInputsBody o && Equals(o);
        }
    }
}
