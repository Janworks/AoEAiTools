﻿using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace AoEAiTools.EditorExtensions.Classification
{
	/// <summary>
	/// Contains the various classification formats.
	/// </summary>
	internal class AiClassifierFormats
	{

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.Comment)]
		[Name("AiCommentFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiCommentClassificationFormat : ClassificationFormatDefinition
		{
			public AiCommentClassificationFormat()
			{
				DisplayName = "AI comment";
				ForegroundColor = Colors.DarkGreen;
			}
		}

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.Default)]
		[Name("AiDefaultFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiDefaultClassificationFormat : ClassificationFormatDefinition
		{
			public AiDefaultClassificationFormat()
			{
				DisplayName = "AI default";
			}
		}

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.Keyword)]
		[Name("AiKeywordFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiKeywordClassificationFormat : ClassificationFormatDefinition
		{
			public AiKeywordClassificationFormat()
			{
				DisplayName = "AI keyword";
				ForegroundColor = Colors.Blue;
			}
		}

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.String)]
		[Name("AiStringFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiStringClassificationFormat : ClassificationFormatDefinition
		{
			public AiStringClassificationFormat()
			{
				DisplayName = "AI string";
				ForegroundColor = Color.FromRgb(163, 21, 21);
			}
		}

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.Number)]
		[Name("AiNumberFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiNumberClassificationFormat : ClassificationFormatDefinition
		{
			public AiNumberClassificationFormat()
			{
				DisplayName = "AI number";
				ForegroundColor = Colors.Goldenrod;
			}
		}

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.Operator)]
		[Name("AiOperatorFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiOperatorClassificationFormat : ClassificationFormatDefinition
		{
			public AiOperatorClassificationFormat()
			{
				DisplayName = "AI operator";
				ForegroundColor = Colors.DarkGray;
			}
		}

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.Delimiter)]
		[Name("AiDelimiterFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiDelimiterClassificationFormat : ClassificationFormatDefinition
		{
			public AiDelimiterClassificationFormat()
			{
				DisplayName = "AI delimiter";
				ForegroundColor = Colors.LightGray;
			}
		}

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = AiClassifierTypes.Identifier)]
		[Name("AiIdentifierFormatDefinition")]
		[UserVisible(true)]
		[Order(Before = Priority.Default)]
		internal sealed class AiIdentifierClassificationFormat : ClassificationFormatDefinition
		{
			public AiIdentifierClassificationFormat()
			{
				DisplayName = "AI identifier";
				ForegroundColor = Colors.Turquoise;
			}
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = AiClassifierTypes.Command)]
        [Name("AiCommandFormatDefinition")]
        [UserVisible(true)]
        [Order(Before = Priority.Default)]
        internal sealed class AiCommandClassificationFormat : ClassificationFormatDefinition
        {
            public AiCommandClassificationFormat()
            {
                DisplayName = "AI command";
                ForegroundColor = Colors.Violet;
            }
        }
    }
}
