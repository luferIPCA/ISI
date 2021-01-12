<?xml version="1.0" encoding="utf-8"?>
<!--Diogo Rocha
    16
    LESI
      ISI-->
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <table border="1" bgcolor="LightSlateGray" table-layout="fixed" width="100%" cellspacing="1" cellpadding="1" display-align="center">
          <tr>
            <td colspan="10" align="center" style="font-weight:bold;">Jogadores da premier league</td>
          </tr>
          <tr bgcolor="Moccasin">
            <th>
              full_name
            </th>
            <th>
              age
            </th>
            <th>
              birthday
            </th>
            <th>
              league
            </th>
            <th>
              season
            </th>
            <th>
              position
            </th>
            <th>
              Current_Club
            </th>
            <th>
             nationality
            </th>
            <th>
              goals_overall
            </th>
          </tr>
          <xsl:for-each select="Rows/Row">
            <tr>
              <xsl:attribute name="bgcolor">
                <xsl:choose>
                  <!--> Varia cores que dependeram da posiçao do jogador-->
                  <xsl:when test="position[.='Forward']">LightGrey</xsl:when>
                  <xsl:when test="position[.='Defender']">#FFD700</xsl:when>
                  <xsl:when test="position[.='Goalkeeper']">#FFFACD</xsl:when>
                  <xsl:when test="position[.='Midfielder']">#228B22</xsl:when>
                  <xsl:otherwise>PowderBlue</xsl:otherwise>
                </xsl:choose>
              </xsl:attribute>
              <td>
                <xsl:value-of select="full_name"/>
              </td>
              <td>
                <xsl:value-of select="age"/>
              </td>
              <td>
                <xsl:value-of select="birthday"/>
              </td>
              <td>
                <xsl:value-of select="league"/>
              </td>
               <td>
                <xsl:value-of select="season"/>
              </td>
              <td>
                <xsl:value-of select="position"/>
              </td>
              <td>
                <xsl:value-of select="Current_Club"/>
              </td>
              <td>
                <xsl:value-of select="nationality"/>
              </td>
                <td>
                <xsl:value-of select="goals_overall"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
