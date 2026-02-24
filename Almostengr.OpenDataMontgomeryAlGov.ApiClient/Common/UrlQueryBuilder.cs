using System.Text;

namespace Almostengr.OpenDataMontgomeryAlGov.ApiClient.Common;

public class UrlQueryBuilder
{
    private readonly StringBuilder _query = new("where=");
    private const string AND = "AND";
    private const string OR = "OR";
    private const string AND_SPACE = " AND ";
    private const string OR_SPACE = " OR ";

    private void AppendCondition(string operation, string field, object value, bool isString)
    {
        if (_query.Length > 0)
        {
            _query.Append($" {operation} ");
        }

        string formattedValue = isString ? $"'{value}'" : value.ToString();
        _query.Append($"{field}={formattedValue}");
    }

    public UrlQueryBuilder AndWhereIn(string field, string[] values)
    {
        if (_query.Length > 0)
        {
            _query.Append(AND_SPACE);
        }

        string enteredValues = string.Join(",", values.Select(v => $"'{v}'"));
        _query.Append($"{field} in ({enteredValues})");
        return this;
    }

    public UrlQueryBuilder AndWhereBetween(string field, int start, int end)
    {
        if (_query.Length > 0)
        {
            _query.Append(" AND ");
        }

        _query.Append($"({field} >= {start} AND {field} <= {end})");
        return this;
    }

    public UrlQueryBuilder AndWhereString(string field, string value)
    {
        AppendCondition(AND, field, value, true);
        return this;
    }

    public UrlQueryBuilder AndWhereInt(string field, int value)
    {
        AppendCondition(AND, field, value, false);
        return this;
    }

    public UrlQueryBuilder AndWhereDateTime(string field, int value)
    {
        AppendCondition(AND, field, value, false);
        return this;
    }

    public UrlQueryBuilder OrWhereString(string field, string value)
    {
        AppendCondition(OR, field, value, true);
        return this;
    }

    public UrlQueryBuilder OrWhereInt(string field, int value)
    {
        AppendCondition(OR, field, value, false);
        return this;
    }

    public UrlQueryBuilder OrWhereDateTime(string field, int value)
    {
        AppendCondition(OR, field, value, false);
        return this;
    }

    public UrlQueryBuilder OrWhereIn(string field, string[] values)
    {
        if (_query.Length > 0)
        {
            _query.Append(OR_SPACE);
        }

        string enteredValues = string.Join(",", values.Select(v => $"'{v}'"));
        _query.Append($"{field} in ({enteredValues})");
        return this;
    }

    public UrlQueryBuilder ReturnCountOnly()
    {
        if (_query.Length > 0)
        {
            _query.Append("&");
        }

        const string countString = "returnCountOnly=true";
        if (!_query.ToString().Contains(countString))
        {
            _query.Append(countString);
        }

        return this;
    }

    public UrlQueryBuilder ReturnIdsOnly()
    {
        if (_query.Length > 0)
        {
            _query.Append("&");
        }

        const string idsString = "returnIdsOnly=true";
        if (!_query.ToString().Contains(idsString))
        {
            _query.Append(idsString);
        }

        return this;
    }

    public UrlQueryBuilder HideGeometry()
    {
        if (_query.Length > 0)
        {
            _query.Append("&");
        }

        const string geoString = "returnGeometry=false";
        if (!_query.ToString().Contains(geoString))
        {
            _query.Append(geoString);
        }

        return this;
    }

    public string Build()
    {
        if (_query.Length == 6)
        {
            _query.Append("1=1");
        }

        return _query.ToString();
    }
}
