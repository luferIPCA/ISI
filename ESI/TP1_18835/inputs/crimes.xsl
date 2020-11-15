<?xml version="1.0"?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html" encoding="ISO-8859-1"/>

<xsl:template match="/">
  <html>
  <head>
    <title>CRIMES</title>
  </head>
  <body>
  <h1>CRIMES</h1>
  <table border="3">
  <tr>
  <th>Cod_Distrito</th>
  <th>Cod_Concelho</th>
  <th>Distrito</th>
  <th>Concelho</th>
  <th>2014</th>
  <th>2013</th>
  <th>2012</th>
  <th>2011</th>
  <th>2010</th>
  <th>2009</th>
  <th>2008</th>
  <th>2007</th>
  <th>2006</th>
  <th>2005</th>
  <th>2004</th>
  <th>2003</th>
  <th>2002</th>
  <th>2001</th>
  <th>2000</th>
  <th>1999</th>
  <th>1998</th>
  <th>1997</th>
  <th>1996</th>
  <th>1995</th>
  <th>1994</th>
  <th>1993</th>
  <th>Total2014-1993</th>
  <th></th>
  </tr>
  <xsl:for-each select="Crimes/Crime">
  <tr>
  <td><xsl:apply-templates select="cod_distrito"/></td>
  <td><xsl:apply-templates select="cod_concelho"/></td>
  <td><xsl:apply-templates select="nome_concelho"/></td>
  <td><xsl:apply-templates select="nome_distrito"/></td>
  <td><xsl:apply-templates select="a2014ncrimes"/></td>
  <td><xsl:apply-templates select="a2013ncrimes"/></td>
  <td><xsl:apply-templates select="a2012ncrimes"/></td>
  <td><xsl:apply-templates select="a2011ncrimes"/></td>
  <td><xsl:apply-templates select="a2010ncrimes"/></td>
  <td><xsl:apply-templates select="a2009ncrimes"/></td>
  <td><xsl:apply-templates select="a2008ncrimes"/></td>
  <td><xsl:apply-templates select="a2007ncrimes"/></td>
  <td><xsl:apply-templates select="a2006ncrimes"/></td>
  <td><xsl:apply-templates select="a2005ncrimes"/></td>
  <td><xsl:apply-templates select="a2004ncrimes"/></td>
  <td><xsl:apply-templates select="a2003ncrimes"/></td>
  <td><xsl:apply-templates select="a2002ncrimes"/></td>
  <td><xsl:apply-templates select="a2001ncrimes"/></td>
  <td><xsl:apply-templates select="a2000ncrimes"/></td>
  <td><xsl:apply-templates select="a1999ncrimes"/></td>
  <td><xsl:apply-templates select="a1998ncrimes"/></td>
  <td><xsl:apply-templates select="a1997ncrimes"/></td>
  <td><xsl:apply-templates select="a1996ncrimes"/></td>
  <td><xsl:apply-templates select="a1995ncrimes"/></td>
  <td><xsl:apply-templates select="a1994ncrimes"/></td>
  <td><xsl:apply-templates select="a1993ncrimes"/></td>
  <td><xsl:apply-templates select="Total19932014crimes"/></td>
  </tr>
  </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>