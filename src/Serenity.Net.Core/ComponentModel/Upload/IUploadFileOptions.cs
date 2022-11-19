﻿namespace Serenity.ComponentModel;

/// <summary>
/// Upload options related to the file name and encoding
/// </summary>
public interface IUploadFileOptions
{
    /// <summary>
    /// Should a copy of file placed in a special history folder on upload. 
    /// This helps preserving old files on update.
    /// </summary>
    public bool CopyToHistory { get; }

    /// <summary>
    /// If you have no original name property but use original
    /// name in file name with {4} format parameter, set this
    /// to true to force the upload editor to show file name.
    /// </summary>
    public bool DisplayFileName { get; }

    /// <summary>
    /// Format of the file name like "ProductImage/{1:00000}/{0:00000000}_{2}".
    /// Parameter 0 is the row identity value, 1 is identity value / 1000, 
    /// and 2 is a random string like 2cxs4bc, 3 is current date/time,
    /// 4 is original file name.
    /// You can also use the shortcut "ProductImage/~" which is equivalent 
    /// to the prior sample.
    /// If you don't specify this, it will default to something like
    /// Product/ProductImage/~ which is generated by combining row class name
    /// and field name.
    /// </summary>
    public string FilenameFormat { get; }

    /// <summary>
    /// Only useful for uploading multiple files. Specifies
    /// whether to JSON encode value. If your field is a string
    /// field set it to true.
    /// </summary>
    public bool JsonEncodeValue { get; }

    /// <summary>
    /// If you want to store original name of the file uploaded,
    /// set this to the name of another string field. Only used
    /// for single image uploads.
    /// </summary>
    public string OriginalNameProperty { get; }
}