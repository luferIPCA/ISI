<?xml version="1.0" encoding="UTF-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
  <html>
  <body>
  <h2>Pokemon</h2>
  <table border="1">
    <tr bgcolor="#9acd32">
      <th>Nº</th>
      <th>Name</th>
      <th>Type 1</th>
      <th>Type 2</th>
      <th>Total</th>
      <th>HP</th>
      <th>Attack</th>
      <th>Defense</th>
      <th>Special Attack</th>
      <th>Special Defense</th>
      <th>Speed</th>
      <th>Generation</th>
      <th>Legendary</th>
    </tr>
    <xsl:for-each select="catalog/cd">
    <tr>
      <td><xsl:value-of select="#"/></td>
      <td><xsl:value-of select="Name"/></td>
      <td><xsl:value-of select="Type 1"/></td>
      <td><xsl:value-of select="Type 2"/></td>
      <td><xsl:value-of select="Total"/></td>
      <td><xsl:value-of select="HP"/></td>
      <td><xsl:value-of select="Attack"/></td>
      <td><xsl:value-of select="Defense"/></td>
      <td><xsl:value-of select="Sp. Atk"/></td>
      <td><xsl:value-of select="Sp. Def"/></td>
      <td><xsl:value-of select="Speed"/></td>
      <td><xsl:value-of select="Generation"/></td>
      <td><xsl:value-of select="Legendary"/></td>
    </tr>
    </xsl:for-each>
  </table>
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>