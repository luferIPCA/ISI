<?xml version="1.0"?> 
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="html" encoding="ISO-8859-1"/>

<xsl:template match="/">
  <html>
  <head>
    <title>TP 1</title>
  </head>
  <body>
  <h1>Animes</h1>
  <table border="3">
  <tr>
  <th>Name</th>
  <th>Rating</th>
  <th>Members</th>
  <th></th>
  </tr>
  <xsl:for-each select="Rows/Row">
  <tr>
  <td><xsl:apply-templates select="name"/></td>
  <td><xsl:apply-templates select="rating"/></td>
  <td><xsl:apply-templates select="members"/></td>
  </tr>
  </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>